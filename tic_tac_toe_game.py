def tic_tac_toe():

    row1 = [" "," "," "]
    row2 = [" "," "," "]
    row3 = [" "," "," "]
    
    print("Let's Play Tic-Tac-Toe!")
    display(row1,row2,row3)
    play_game()

def play_game():
    
    # Initalize the board as empty
    row1 = [" "," "," "]
    row2 = [" "," "," "]
    row3 = [" "," "," "]
    # Initialize the parameter to keep the game going
    keep_playing = True
    
    # Have Players select if they are X or O
    player1,player2 = player_select()
    
    while keep_playing == True:
        # Player 1 picks his square, the board is updated and displayed
        pick1 = picks(player1,"Player 1")  
        row1,row2,row3 = board_status(player1,pick1,row1,row2,row3)
        display(row1,row2,row3)
        
        # Checks to see if the game has ended by player1 win or draw
        if game_over(row1,row2,row3) == "X" or game_over(row1,row2,row3) == "O" or game_over(row1,row2,row3) == "draw":
            keep_playing = False
            break
            
        # Player 2 picks his square, the board is updated and displayed
        pick2 = picks(player2,"Player 2")
        row1,row2,row3 = board_status(player2,pick2,row1,row2,row3)
        display(row1,row2,row3)
        
        # Checks to see if the game has ended by player2 win or draw
        if game_over(row1,row2,row3) == "X" or game_over(row1,row2,row3) == "O" or game_over(row1,row2,row3) == "draw":
            keep_playing = False
            break
            
    #Announce Winner
    announce_winner(row1,row2,row3,player1,player2)
        
def display(row1, row2, row3):


    
    game = f""" {row1[0]} | {row1[1] } | {row1[2]}"""
    game2 = f""" {row2[0]} | {row2[1] } | {row2[2]}"""
    game3 = f""" {row3[0]} | {row3[1] } | {row3[2]}"""
    
    print(game)
    print(" ----------")
    print(game2)
    print(" ----------")
    print(game3)

def game_over(row1,row2,row3):
    
    x_win = ["X", "X", "X"]
    o_win = ["O", "O", "O"]
    winner = " "
    
    column1 = [row1[0], row2[0], row3[0]]
    column2 = [row1[1], row2[1], row3[1]]
    column3 = [row1[2], row2[2], row3[2]]
    
    diagonal1 = [row1[0], row2[1], row3[2]]
    diagonal2 = [row1[2], row2[1], row3[0]]
    
    # Check Horizantal columns
    if row1 == x_win  or row2 == x_win or row3 == x_win:
        winner = "X"
    elif row1 == o_win  or row2 == o_win or row3 == o_win:
        winner = "O"
    # Check Vertical Columns
    elif column1 == x_win or column2 == x_win or column3 == x_win:
        winner = "X"
    elif column1 == o_win or column2 == o_win or column3 == o_win:
        winner = "O"
    # Check Diagonally
    elif diagonal1 == x_win or diagonal2 == x_win:
        winner = "X"
    elif diagonal1 == o_win or diagonal2 == o_win:
        winner = "O"
    elif " " not in row1 and " " not in row2 and " " not in row3:
        winner = "draw"
    return winner

def board_status(player,selection,row1,row2,row3):
    
    if selection == 1 and row1[0] == " ":
        row1[0] = player
    if selection == 2 and row1[1] == " ":
        row1[1] = player
    if selection == 3 and row1[2] == " ":
        row1[2] = player
    if selection == 4 and row2[0] == " ":
        row2[0] = player
    if selection == 5 and row2[1] == " ":
        row2[1] = player
    if selection == 6 and row2[2] == " ":
        row2[2] = player
    if selection == 7 and row3[0] == " ":
        row3[0] = player
    if selection == 8 and row3[1] == " ":
        row3[1] = player
    if selection == 9 and row3[2] == " ":
        row3[2] = player
    
    return row1,row2,row3

def picks(player_symbol,player):
    
    pick = None
    p_done = False
    selected = []
    
    while p_done == False:
            pick = input(f"{player}({player_symbol}): select a Square (1,2,3) (4,5,6) (7,8,9): ").upper()
            if pick not in "123456789":
                print("Must Pick a number b/w 1-9!")
                continue
            else:
                if int(pick) in selected:
                    print("Square already selected!")
                    continue
                else:
                    pick = int(pick)
                    selected.append(pick)
                    p_done = True
                    
    return pick

def announce_winner(row1,row2,row3,player1,player2):
    
    if game_over(row1,row2,row3) == player1:
        print(f"Player 1 {player1} Wins!")
    elif game_over(row1,row2,row3) == player2:
        print(f"Player 2 {player2} Wins!")
    elif game_over(row1,row2,row3) == "draw":
        print("There was a Draw...")           

def player_select():
    player1 = None
    player2 = None
    
    while player1 != "X" or player1 != "O":
        player1 = input("Player 1: Select X or O: ").upper()
        if player1 == "X":
            player2 = "O"
            break
        elif player1 == "O":
            player2 = "X"
            break
        else:
            print("You Must Only Select X or O!")
            
    return player1, player2