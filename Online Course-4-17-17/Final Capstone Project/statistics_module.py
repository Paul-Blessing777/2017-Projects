import math

def median(list1):
    easy_median = False
    median = 0.0
    list1.sort()
    
    median_pos = (len(list1)+1) / 2
    
    if int(median_pos) == median_pos:
        easy_median = True
        
    if easy_median == True:
        median = list1[int(median_pos)-1]
        return float(median)
    else:
        lower_median_pos = int(median_pos-1)
        upper_median_pos = int(median_pos)
        median = ((list1[upper_median_pos]) + (list1[lower_median_pos])) /2
        return float(median)
    
def mean(a_list):
    return sum(a_list) / len(a_list)


def variance(a_list):
    mean = sum(a_list) / len(a_list)
    x_sum = 0
    
    for num in a_list:
        x_sum += (num - mean)**2
        
    return (x_sum* 1/(len(a_list)-1))

def variance_bias(a_list):
    mean = sum(a_list) / len(a_list)
    x_sum = 0
    
    for num in a_list:
        x_sum += (num - mean)**2
        
    return (x_sum* 1/(len(a_list)))

def standard_dev(a_list):

        
    return variance(a_list)**.5

def find_q1_q2(list22):
    low_list = []
    high_list = []
    list22.sort()
    

    median_position = (len(list22)+1) / 2
    for num in list22:
        if (list22.index(num)) +1 < median_position:
            low_list.append(num)

        elif (list22.index(num))+1 > median_position:
            high_list.append(num)
            
    return median(low_list), median(high_list)

def interquartile_range(q1,q3):
    
    return q3-q1

def is_outlier_median(a_list):
    
    q1,q3 = find_q1_q2(a_list)
    iqr = q3 - q1
    low_outlier_marker = q1-(1.5*iqr)
    high_outlier_marker = q3+(1.5*iqr)
    
    outlier_list = []
    
    for item in a_list:
        if item < low_outlier_marker:
            outlier_list.append(item)
        elif item > high_outlier_marker:
            outlier_list.append(item)
    
    return outlier_list

def is_outlier_mean(a_list):
    
    mean1 = mean(a_list)
    sdv = standard_dev(a_list)
    outlier_low = []
    outlier_high = []
    
    for num in a_list:
        if num > (mean1+(sdv*2)) and num > (mean1+(sdv*3)):
            outlier_high.append(num)
        elif num < (mean1-(sdv*2)) and num < (mean1-(sdv*3)):
            outlier_high.append(num)
        elif num > (mean1+(sdv*2)):
            outlier_low.append(num)
            print(num)
        elif num < (mean1-(sdv*2)):
            outlier_low.append(num)
        else:
            pass
    
    return(outlier_high, outlier_low)

def give_stats(a_list):
    q1,q3= find_q1_q2(a_list)
    interquartile_range(q1,q3)
    
    print(f"Median: {median(a_list)}")
    print(f"Mean: {round(mean(a_list),2)}")
    print(f"Standard Deviation: {round(standard_dev(a_list),2)}")
    print(f"Q1: {round(find_q1_q2(a_list)[0],2)}")
    print(f"Q3: {round(find_q1_q2(a_list)[1],2)}")
    print(f"Interquartile Range: {round(interquartile_range(q1,q3),2)}")
    print(f"Outliers Median Method: {is_outlier_median(a_list)}")
    print(f"Outliers Mean Method Strong (3+SDV): {is_outlier_mean(a_list)[0]}")
    print(f"Outliers Mean Method Weak (2SDV): {is_outlier_mean(a_list)[1]}")
    print(f"Minimum Value: {min(a_list)}")
    print(f"Maximum Value: {max(a_list)}")
    
def z_score(num, sdv, mean):
    
    return (num - mean) / sdv

def correlation_coefficient(data_set):
    
    x_list = []
    y_list = []
    z_sum = 0
    n = len(data_set)
    
    for x,y in data_set:
        x_list.append(x)
        y_list.append(y)
        
    x_mean = mean(x_list)
    y_mean = mean(y_list)
    
    x_sdv = standard_dev(x_list)
    y_sdv = standard_dev(y_list)
    
        
    for x_num,y_num in data_set:
        z_sum += (z_score(x_num, x_sdv, x_mean) * z_score(y_num, y_sdv,y_mean))

    return ((z_sum) / (n-1))

def regression_line(a_tuple,give_values=False):
    x_list = []
    y_list = []

    for x,y in a_tuple:
        x_list.append(x)
        y_list.append(y)
        
    sdv_y = standard_dev(y_list)
    sdv_x = standard_dev(x_list)
    
    y_mean = mean(y_list)
    x_mean = mean(x_list)
    r = correlation_coefficient(a_tuple)
        
    b = r * (sdv_y / sdv_x) # b= r * (sdv_y / sdv_x)
    a = y_mean - (b*x_mean) # a = mean_y - b * mean_x
    
    if give_values == False:
        print(f" ŷ = {round(a,2)}+{round(b,2)}x")
    
    if give_values == True:
        return a, b
    
def predict_y(a_tuple, x_predict):

    a,b = regression_line(a_tuple, True)

    y_predict = a + (b * x_predict)
    
    return round(y_predict,3)
    
def predict_x(a_list, y_value):
    
    a,b = regression_line(a_list, True)
        
    x_predict = (y_value - a) / b
    
    return round(x_predict,3)

def residual(a_list,x,y):
        
    y_hat = predict_y(a_list, x)

    return y-y_hat

def average_residual(a_list):
    n = len(a_list)
    total_yhat = 0
    total_y = 0

    for x_num, y_num in a_list:
        total_yhat += predict_y(a_list, x_num)
        total_y += y_num
        
    total_residual = total_y - total_yhat
    avg_residual = total_residual / n
    
    return round(avg_residual,3) 

def total_residual(a_list):
    n = len(a_list)
    total_yhat = 0
    total_y = 0

    for x_num, y_num in a_list:
        total_yhat += predict_y(a_list, x_num)
        total_y += y_num
        
    total_residual = total_y - total_yhat
    
    return total_residual

def sum_of_squares_total(a_list):
    y_list = []
    sum_squares_total = 0
    
    for x,y in a_list:
        y_list.append(y)
        
    # find mean of y
    y_mean = mean(y_list)
    
    for y in y_list:
        sum_squares_total += (y - y_mean)**2
        
    return sum_squares_total

def coefficient_determination(a_list):
    """
    Gives coefficient of determination via two means, first (SST-SSE)/SST then r**2
    """
    

    sum_squared_errors = total_residual(a_list)
    sum_squares_total = sum_of_squares_total(a_list)

    
    return ((sum_squares_total - sum_squared_errors) / sum_squares_total), correlation_coefficient(a_list)**2

def transform_predicted_y(a_list,x_predict):
    """
    Takes the predicted y value and e^x to fix it
    """
    
    y_predicted = predict_y(a_list,x_predict)
    
    return math.exp(y_predicted)

def transform_bivariate(a_list):
    transformation = []
    for x, y in a_list:
        transformation.append((x,math.log(y)))
        
    return transformation

def sum_of_squared_errors(a_list):
    return total_residual(a_list)
        
    
