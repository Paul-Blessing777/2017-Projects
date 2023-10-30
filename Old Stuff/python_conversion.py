import datetime
import os.path
from os import path
import shutil
import cx_Oracle

iniFileName = "TireRegistration.ini"
iniPath = "D:/TireRegistration/"
logFileName = 'ts_logfile.txt'
logFilePath = "D:/TireRegistration/Log"


def DBConnection(DBstatus):
    """This function can be called to either open the DB connection or close it"""
    conn = cx_Oracle.connect("TRSADMIN", "TRS", "DBX03T")
    if DBstatus == True:
        return conn
    else:
        conn.close()
        
def loadWebOps():
    """Runs the WebOps stored Procedure"""
    DBstatus = True
    conn = DBConnection(DBstatus)
    c = conn.cursor()
    c.callproc("load_webops_tr")
    
        
def createFordAcknowledgement(record_count, outputDir, archiveDir):
    """Creates the ford acknowledgement file"""
    date = datetime.datetime.now()
    date = date.strftime('%c')

    logFile = open(f"{logFilePath + logFileName}", "a")
    
    DBstatus = True
    conn = DBConnection(DBstatus)
    c = conn.cursor()
    c.execute('select FORD_ACKNOWLEDGEMENT_BATCH_SEQ.nextval from DUAL')
    
    for result in c:
        batchNum = result[0]
        if batchNum == '':
            date = datetime.datetime.now()
            date = date.strftime('%c')
            print(f"{date} **WARNING** - Next FORD_ACKNOWLEDGEMENT_BATCH_SEQ number not returned from Oracle", file = logFile)
            
    # Create and write the ack file
    fileName = f"{outputDir}DOT_{batchNum}_ack.txt"
    infile = open(fileName, "w")
    print(f"{batchNum} {record_count}-records processed", file = infile)
    infile.close()
    
    # Make a copy in the archive folder
    archiveName = f"{archiveDir}DOT_{batchNum}_ack{date[0:11]}.txt"
    shutil.copy(fileName, archiveName)
    
    
def executeStoredProcedure(sourceID, record, firstRecord):
    """Executes the main Stored Procedure for updating the DB"""
    DBstatus = True
    conn = DBConnection(DBstatus)
    c = conn.cursor()
    c.callproc('maintain_tire_registration',[sourceID, record, firstRecord] )
    
    
def getTireRegistrationRecords(fileName, sourceID, outputDir, archiveDir):
    """Goes through the TireReg files record by record executing the stored procedure in order to update the DB"""
    record_count = 0
    logFile = open(logFilePath + logFileName, "a")
    
    try:
        #Tries to open the file and go through its contents; if the file is over 375 records an error is logged
        firstRecord = "True"
        infile = open(fileName, "r")
        rows = infile.readlines()
        rows_string = ''.join(rows)
        rows_list = rows_string.split('\n')
        for record in rows_list:
            length = len(record)
            date = datetime.datetime.now()
            date = date.strftime('%c')
            record_count += 1
        
            if length > 375:
                print(f"{date} **Warning** - Record too long - Record Length {length} record: {record}", file = logFile)
            else:
                executeStoredProcedure(sourceID, record, firstRecord)
                firstRecord = 'False'
                
        infile.close()
        print(f"{date} INFO - Processed - Records: {record_count}  SourceID: {sourceID}", file = logFile)
        logFile.close()
        
        
        """For special cases when SourceID is from Ford"""
        if sourceID == 'FORD':
            createFordAcknowledgement(record_count, outputDir, archiveDir)

    except:
        date = datetime.datetime.now()
        date = date.strftime('%c')
        print(f"{date} **ERROR** - Parsing {fileName} ERROR - Record Count {record_count} File Name: {fileName}", file = logFile)
    
    logFile.close()
      
    
def main():

    iniFirst = []
    iniSecond = []
    trFilesFirst = []
    trFilesSecond = []
    DBstatus = False
    
    """Trys to open the logFile, if it can't append to it, it makes a new log file"""
    try:
        logFile = open(logFilePath+logFileName, "a")
    except:
        logFile = open(logFilePath+logFileName, "w")
    
    """Try and find the file, if the file is found logic is applied to its contents and saved as variables
    Otherwise an error is written to the log file"""
    
    try:
        infile = open(iniPath+iniFileName, "r")
        
        '''Loops through the file splitting each line by a '='; then saves the split in first & second
        then appends first and second to iniFirst and iniSecond respectively'''
        
        for line in infile:
            first_infile, second_infile = line.split('=')
            iniFirst.append(first_infile), iniSecond.append(second_infile)
        
        '''Goes through the iniFirst list and verifies the necessary value, then saves a variable with
        the value of the corresponding iniSecond value'''
        
        if iniFirst[0] == 'Database':
            dbName = iniSecond[0]
            
        if iniFirst[1] == 'InputDir':
            inputDir = iniSecond[1]
            
        if iniFirst[2] == 'OutputDir':
            outputDir = iniSecond[2]
            
        if iniFirst[3] == 'ArchiveDir':
            archiveDir = iniSecond[3]
            
        if iniFirst[4] == 'LogDir':
            logDir = iniSecond[4]
            
        if iniFirst[5] == 'FileCount':
            fileCount = iniSecond[5]
            
        if iniFirst[6] == 'InputFiles':
            inputFiles = iniSecond[6]
            trFiles = inputFiles.split(",")
            
        # Closes the file
        print(f"Found: {iniPath+iniFileName} File", file = logFile)
        infile.close()
        
    except:
        """If the file is not found write to the log file the error and the date/time"""
        date = datetime.datetime.now()
        date = date.strftime('%c')
        print(f"{date} **Error** - Could not find {iniPath+iniFileName}", file = logFile)
        logFile.close()
    
    
    '''Trys to append to the log file. If no log file is found it creates one. It then goes through the trFiles
    and splits the contents by a ':' '''
    for record in trFiles:
        first_trFiles, second_trFiles = record.split(":")
        trFilesFirst.append(first_trFiles), trFilesSecond.append(second_trFiles)
    
    '''Writes to the log file if it find the file otherwise writes that it couldnt find the value'''
    counter = 0
    for file in trFilesSecond:
        # Creates dates for the files
        date = datetime.datetime.now()
        date = date.strftime('%c')
        date2 = date
        date2 = date2[:10] + date2[19:] # Making the date ok for placement of a filename (Removing "/")
        
        # Would be inputDir in production
        fileName = f"{inputDir + trFilesSecond[0+counter]}" # This would be the inputDir file
        if path.exists(fileName):
            print(f"{date} INFO - {inputDir} {trFilesSecond[0+counter]} {trFilesFirst[0+counter]} file found and opening processing", file = logFile)
            getTireRegistrationRecords(fileName, trFilesFirst[0+counter], outputDir, archiveDir)
            DBConnection(DBstatus=False)
            newFile = f"{archiveDir + trFilesSecond[0+counter]}" 
            shutil.move(fileName, newFile) # Move the file to archive
            newFile2 = newFile[:-4] # Get's rid of .txt so I can append the date
            os.rename(newFile, newFile2 + date2 +'.txt') # Renames the file with the date appended
        else:
            print(f"{date} INFO - {inputDir} {trFilesSecond[0+counter]}: {trFilesFirst[0+counter]} file NOT found", file = logFile)
        counter += 1
            
    # Runs the WebOps stored procedure
    date3 = datetime.datetime.now()
    date3 = date3.strftime('%c')
    print(f"{date3} INFO  - Loading WEBOPS Tire Registrations", file = logFile)
    loadWebOps()
    date4 = datetime.datetime.now()
    date4 = date4.strftime('%c')
    print(f"{date4} INFO  - Done Loading WEBOPS Tire Registrations", file = logFile)
    print(f"{date4} SCRIPT FINISHED", file = logFile)

    # Close the DB connection and close the log file
    DBstatus = False
    DBConnection(DBstatus)
    logFile.close()

