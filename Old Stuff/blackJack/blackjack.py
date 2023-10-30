from random import randrange
from IPython.display import clear_output
import time
from math import sqrt, sin, cos, radians, degrees
from graphics import *
from button import Button



def black_jack():
    
    # Initalize variables
    game_over = False
    counter = 0
    
    # Finds out how many players there will be: max 5
    n_players = int(input('How many players are there? (Max 5):'))
    while n_players < 1 or n_players > 5:
        n_players = int(input('How many players are there? (Max 5):'))
        
    # Creates a list of players, and a list of players still in the game (T/F)
    player_list,players_in = create_players(n_players)
    
    
    # Get's the players' and dealer's hands
    players_cards, players_hands = get_initial_hand(player_list)
    #players_hands = [15]
    dealer_hand, hidden_card = get_dealer_hand()
    #dealer_hand, hidden_card = 10, 5
    #show_hands(players_hands,player_list)
    
    """Shows the dealer's hand and one of their cards"""
    dealer_win = DealerHand(dealer_hand,dealer_hand-hidden_card)
    while True:
        choice = dealer_win.interact()
        if choice == "Done":
            dealer_win.close()
            break
    
    """Shows The players their hands"""
    inputwin = ShowHand(player_list[0])
    counterSpecial = 0
    for i in player_list:
        while True:
            choice = inputwin.interact()
            if choice == "Hand":
                inputwin.update(player_list[0+counterSpecial],players_hands[0+counterSpecial])
            elif choice == "Done":
                inputwin.update(0,0)
                counterSpecial += 1
                #window.close()
                break
    inputwin.close()
    

        
    # Checks for a game over
    game_over, win, players_in2 = game_check_new(players_hands,dealer_hand,player_list,players_in)
    
    """In case of a rare first hand == 21 shows the players hands"""
    if game_over == True:
        #print(f"Congratz {win}! You hit the 21!")
        win1 = GameOver(game_over,win)
        choice = win1.interact()
        while True:
            if choice == "Quit":
                win1.close()
                break
        print(f"The Dealers hidden card was {hidden_card} there other card {dealer_hand-hidden_card} for a total hand of {dealer_hand}")
        show_hands(players_hands,player_list)
    elif game_over == 'draw':
        #print(f"Draw between {win} and the dealer! All hit 21")
        win1 = GameOver(game_over,win)
        choice = win1.interact()
        while True:
            if choice == "Quit":
                win1.close()
                break
        print(f"The Dealers hidden card was {hidden_card} there other card {dealer_hand-hidden_card} for a total hand of {dealer_hand}")
        game_over = True
    # Makes sure the game hasn't ended
    if game_over != True:
        clear_output()
    
    
    
        # Remove Players who have busted
        players_hands2,players_in3,player_list2 = remove_players(players_in2,players_hands,player_list)
        
        """Allow players to add cards if they'd like"""
        players_hands3,players_in4,player_list3 = add_cards(players_hands2,player_list2,dealer_hand,players_in3)
        clear_output()
        show_hands(players_hands3,player_list3)

        # Checks for game over
        game_over, win, pp = game_check_new(players_hands3,dealer_hand,player_list3,players_in4)
        if win == 'dealer':
            win1 = GameOver(game_over,win)
            choice = win1.interact()
            while True:
                if choice == "Quit":
                    win1.close()
                    break
        elif game_over == True:
            win1 = GameOver(game_over,win)
            choice = win1.interact()
            while True:
                if choice == "Quit":
                    win1.close()
                    break
       
        # Reveals the dealer's hidden card and their total hand
        print(f"The Dealers hidden card was {hidden_card} there other card {dealer_hand-hidden_card} for a total hand of {dealer_hand}")
        
        # Runs until we've reached an game over state
        while game_over != True:
            # If the dealer lands b/w 17 and 21 they are set and it checks for a winner
                if dealer_hand >= 17 and dealer_hand <= 21:
                    game_over = game_check_new(players_hands3,dealer_hand,player_list3,players_in4)[0]
                    win = game_check_new(players_hands3,dealer_hand,player_list3,players_in4)[1]
                    #win1 = GameOver(game_over,win)
                    if game_over == 'dealer_bust':
                        highest, winners = highest_score(players_hands3,player_list3)
                        win1 = GameOver(game_over,winners)
                        choice = win1.interact()
                        while True:
                            if choice == "Quit":
                                win1.close()
                                break
                        print(f"Congratz {winners}! You had the highest Score and the dealer busted!")
                        game_over = True
                        break
                    elif game_over == 'Special':
                        print(f"Hit the special where dealer is between 17 and 21")
                        # Compares the dealer's hand to the remaning players for the winner
                        highest, winner = highest_score(players_hands3,player_list3)
                        dealer_hand,win, best,loser = final_compare(highest,winner,dealer_hand)
                        win8 = GameOverSpecial(win,winner,best,loser)
                        choice = win8.interact()
                        while True:
                            if choice == 'Quit':
                                win8.close()
                                break
                        game_over = True
                        break
                else:
                    # Keeps adding cards until the dealer hits b/w 17-21 or busts
                    counter +=1
                    dealer_hand = add_card(dealer_hand)
                    print()
                    print(f'{counter} cards added: New dealer hand {dealer_hand}')
                    game_over,win, players_in = game_check_new(players_hands3,dealer_hand,player_list3,players_in4)
                    if win == 'dealer':
                        win1 = GameOver(game_over,win)
                        choice = win1.interact()
                        while True:
                            if choice == "Quit":
                                win1.close()
                                break

                    # If the dealer busts looks for who had the highest score out of remaining players
                if game_over == 'dealer_bust':
                    highest, winners = highest_score(players_hands3,player_list3)
                    dealer_hand,win, best,loser = final_compare(highest,winners,dealer_hand)
                    win8 = GameOverSpecial(win,winners,best,loser)
                    choice = win8.interact()
                    while True:
                        if choice == 'Quit':
                            win8.close()
                            break
                    game_over = True
                    break
                continue

def add_cards(players_hands,players,dealer_hand,players_in):
    add = False
    counter = -1
    cards = {1:0,2:2,3:3,4:4,5:5,6:6,7:7,8:8,9:9,10:10,11:10,12:10}
    new_hand = players_hands
    end = False
    
    for i in players_hands:
        counter += 1
        new_card = randrange(1,13)
        win3 = AddingCards(players[0+counter],players_hands[0+counter])
        choice = win3.interact()
        if choice == "Done":
            win3.close()
        while choice != 'Done':
            if choice == "Add":
                if is_ace(cards[new_card]) == True:
                    new_card = ace_value(players_hands[0+counter])
                    new_hand[0+counter] += new_card
                    print(f"{players[0+counter]}: new card added to hand {new_card}")
                    print(f"{players[0+counter]}: Hand is now: {new_hand[0+counter]}")
                    win3.update(players[0+counter],new_hand[0+counter],new_card)
                    if game_check2(new_hand[0+counter],dealer_hand)[0] == 'out':
                        players_in[0+counter] = remove_players(players_in,new_hand,players)[2]
                        win3.update(players[0+counter],new_hand[0+counter],new_card)
                        choice2 = win3.interact()
                        while choice2 != 'Done':
                            choice2 = win3.interact()
                        win3.close()
                        break
                    choice2 = win3.interact()
                    if choice2 == "Done":
                        win3.close()
                        break
                else:
                    new_card = cards[new_card]
                    new_hand[0+counter] += new_card
                    print(f"{players[0+counter]}: New card added to hand {new_card}")
                    print(f"{players[0+counter]}: Hand is now: {new_hand[0+counter]}")
                    win3.update(players[0+counter],new_hand[0+counter],new_card)
                    if game_check2(new_hand[0+counter],dealer_hand)[0] == 'out':
                        win3.update(players[0+counter],new_hand[0+counter],new_card)
                        choice2 = win3.interact()
                        while choice2 != 'Done':
                            choice2 = win3.interact()
                        win3.close()
                        break
                    choice2 = win3.interact()
                    if choice2 == "Done":
                        win3.close()
                        break
                    else:
                        continue
            elif choice == "Done":
                win3.close()
                break
                        
    players_in2 = game_check_new(new_hand,dealer_hand,players,players_in)[2]
    players_hands2,players_in3,players2 = remove_players(players_in2,new_hand,players)
    return players_hands2,players_in3,players2

def game_check_new(players_hands,dealer_hand,players,players_in):
    
    win = []
    counter = 0
    end = False
    players_in2 = players_in
    draw = False
    
    if players_hands != []:
        for i in players_hands:
            if players_hands[0+counter] == 21:
                win.append(players[0+counter])
            elif players_hands[0+counter] > 21 and dealer_hand <= 21:
                print(f"Sorry {players[0+counter]} you went bust! You Lose")
                #win = 'player_out'
                players_in2[0+counter] = False
            counter +=1
    else:
        end = True
        print(f"All players busted! The dealer Wins!")
        win = 'dealer'
        
    if win != [] and dealer_hand == 21:
        print(f"Woah looks like a draw! B/W {win} and the dealer")
        end = 'draw'
    elif win != [] and dealer_hand != 21:
        print(f"Congratz {win} you hit 21!")
        end = True
    elif win == [] and dealer_hand == 21:
        print('Sorry the Dealer hit 21. You lose!')
        end = True
        win = 'dealer'
    elif win == [] and dealer_hand >= 17 and dealer_hand < 21:
        end = 'Special'
    elif win == [] and dealer_hand > 21:
        end = 'dealer_bust'
    
        
    return end, win, players_in2

def show_hand(hand,player):
    print(f"{player}'s hand is: {hand}")



def game_check2(player_hand,dealer_hand):
 
    win = ''
    if player_hand == 21 and dealer_hand == 21:
        #print("Woah looks like a draw!")
        win = 'draw'
        return 'out', win
    elif player_hand == 21:
        #print("Congratz! You Won!")
        win = 'player'
        return 'out',win
    elif dealer_hand == 21:
        #print("Sorry you lost! The dealer hit 21 and you didn't!")
        win = 'dealer'
        return 'out', win
    elif player_hand <= 21 and dealer_hand > 21:
        #print("The dealer went bust! You win!")
        win = 'player'
        return 'out', win
    elif player_hand > 21 and dealer_hand <= 21:
        #print("Sorry you went bust! You Lose")
        win = 'dealer'
        return 'out', win
    else:
        return 'in', win


def remove_players(players_in,players_hands,players):
    
    counter = 0
    place = 0
    removes_hands = []
    removes_in = []
    removes_players = []
    counter2 = 0
    
    for i in players_in:
        if players_in[0+counter] == False:
            #print(f"Sorry {players[0+counter]}! You busted and are out!")
            #place = players_hands[0+counter]
            #players_hands.remove(place)
            removes_hands.append(players_hands[0+counter])
            removes_in.append(players_in[0+counter])
            removes_players.append(players[0+counter])
            
        counter += 1
    
    for i in removes_hands:
        players_hands.remove(removes_hands[0+counter2])
        players_in.remove(removes_in[0+counter2])
        players.remove(removes_players[0+counter2])
        counter2 += 1
 
    
        
    return players_hands,players_in,players
        

def show_hands(hands,players):
    counter = 0
    
    for i in hands:
        print(f"{players[0+counter]}'s hand is: {hands[0+counter]}")
        counter += 1

def get_dealer_hand():

    
    # Get's the card values for the 2 player cards and 2 dealer cards
    dealer1 = randrange(1,13)
    #dealer1 = 1
    dealer2 = randrange(1,13)
    #dealer2 =  10
   
    
    # Dict that assigns the value of each card 1--12 are face cards and each worth 10, ace is worth zero for now
    cards = {1:0,2:2,3:3,4:4,5:5,6:6,7:7,8:8,9:9,10:10,11:10,12:10}
    

    # Calculates the player and dealers intial hands not accounting for aces yet
    dealer_hand = cards[dealer1] + cards[dealer2]
    
    dealer1 = cards[dealer1]
    dealer2 = cards[dealer2]
    # Calculates the value of any aces found
    dealer_ace1, dealer_ace2 = check_for_aces(dealer1,dealer2,dealer_hand)
    
    if dealer_ace1 == 1 or dealer_ace1 == 11:
        dealer1 = dealer_ace1
    if dealer_ace2 == 1 or dealer_ace2 == 11:
        dealer2 = dealer_ace2
    
    # Recalculates the values of the hands if any aces were found
    dealer_hand2 = dealer1 + dealer2
        
    print(f"Dealers Cards: {dealer1}, ???")
        
    
    # Prints the hand and returns them as variables
    return dealer_hand2, dealer2

def check_for_aces(dealer1,dealer2,dealer_hand):
        
    # Sets the intial value of potential ace cards to zero
    dealer_ace1 = 0
    dealer_ace2 = 0
    
    if is_ace(dealer1) == True:
        dealer_ace1 = ace_value(dealer_hand)
    if is_ace(dealer2) == True:
        dealer_ace2 = ace_value(dealer_hand)
    
    if dealer_ace1 == 1 and dealer_ace2 == 1:
        print("You have Two Aces!")
        print()
        double_ace_value = int(input("Would you like your aces to be worth 2 or 12? "))
        print()
        if double_ace_value == 2:
            dealer_ace1,dealer_ace2 = 1,1
        elif double_ace_value == 12:
            dealer_ace1, dealer_ace2 = 11,1
        
    return dealer_ace1, dealer_ace2
        

def final_compare(highest,winner,dealer_hand):
    if dealer_hand > 21:
        dealer_hand = 0
    if highest == dealer_hand:
        win = 'draw'
        best = highest
        loser = highest
        return winner,win, best, loser
    elif highest > dealer_hand:
        win = 'players'
        best = highest
        loser = dealer_hand
        return winner,win, best, loser
    elif dealer_hand > highest:
        win = 'dealer'
        best = dealer_hand
        loser= highest
        return dealer_hand,win, best,loser

def game_check(players_hands,dealer_hand,players,players_in):
    
    win = []
    counter = 0
    end = False
    players_in2 = players_in
    
    if players_hands != []:
        for i in players_hands:
            if players_hands[0+counter] == 21 and dealer_hand == 21:
                print(f"Woah looks like a draw! B/W {players[0+counter]} and the dealer")
                #win = 'draw'
                win.append(players[0+counter])
                end = 'draw'
                break
            elif players_hands[0+counter] == 21:
                #print(f"Congratz! {players[0+counter]} you hit 21: You Won!")
                win.append(players[0+counter])
                end = True
            elif dealer_hand == 21:
                print("Sorry you lost! The dealer hit 21 and you all didn't!")
                win = 'dealer'
                end = True
                break
            elif players_hands[0+counter] <= 21 and dealer_hand > 21:
                #print(f"The dealer went bust!")
                win.append(players[0+counter])
                end = 'Special'
            elif players_hands[0+counter] > 21 and dealer_hand <= 21:
                print(f"Sorry {players[0+counter]} you went bust! You Lose")
                #win = 'player_out'
                players_in2[0+counter] = False
            counter +=1
    else:
        end = True
        print(f"All players busted! The dealer Wins!")
        win = 'dealer'
    return end, win, players_in2

def highest_score(players_hands,players):
    counter = 0
    compare = []
    compare_player = []
    winners = []
    
    if players_hands != []:
        for i in players_hands:
            if players_hands[0+counter] <= 21:
                compare.append(players_hands[0+counter])
                compare_player.append(players[0+counter])
            counter += 1

        highest = max(compare)
        players_hands.count(highest)

        counter = 0
        for i in players_hands:
            if players_hands[0+counter] == highest:
                winners.append(players[0+counter])
            counter += 1
    else:
        highest = 0
    
    return highest, winners

def ace_value(hand):
    if hand + 11 >= 17 and hand + 11 <= 21:
        return 11
    else:
        return 1

def is_ace(card):
    if card == 0:
        return True
    else:
        return False

def create_players(n_players):
    player_list = []
    players_in = []
    
    for i in range(1,n_players+1):
        players_in.append(True)
    
    for player in range(1,n_players+1):
        player_list.append('Player' + str(player))
        
    return player_list,players_in

def get_initial_hand(players):
    cards = {1:0,2:2,3:3,4:4,5:5,6:6,7:7,8:8,9:9,10:10,11:10,12:10}
    player_hands = []
    player_hands2 = []
    player_hands3 = []
    player_hands4 = []
    counter = 0
    
    for player in players:
        player_hands.append([randrange(1,13), randrange(1,13)])
    
    for i in players:
        player_hands2.append([cards[player_hands[0+counter][0]], cards[player_hands[0+counter][1]]])
        counter +=1
    counter = 0
    
    player_hands3 = check_aces(player_hands2)
    for i in players:
        player_hands4.append(player_hands3[0+counter][0]+ player_hands3[0+counter][1])
        counter += 1
        
    #player_hands3 = check_aces(player_hands2)
        
    return player_hands3,player_hands4

def check_aces(player_hands):
    counter = 0
    
    for i in player_hands:
        if is_ace(player_hands[0+counter][0]) == True:
            hand = player_hands[0+counter][0] + player_hands[0+counter][1]
            player_hands[0+counter][0] = ace_value(hand)
        counter += 1
    
    counter = 0
    for i in player_hands:
        if is_ace(player_hands[0+counter][1]) == True:
            hand = player_hands[0+counter][0] + player_hands[0+counter][1]
            player_hands[0+counter][1] = ace_value(hand)
        counter += 1
        
    counter = 0
    for i in player_hands:
        if player_hands[0+counter][0] == 1 and player_hands[0+counter][1] == 1:
            print("You have Two Aces!")
            print()
            double_ace_value = int(input("Would you like your aces to be worth 2 or 12? "))
            print()
            if double_ace_value == 2:
                player_hands[0+counter][0],player_hands[0+counter][1] = 1,1
                
            elif double_ace_value == 12:
                player_hands[0+counter][0],player_hands[0+counter][1] = 11,1
                
        counter += 1
    return player_hands

class GameOverSpecial:
    
        def __init__(self,win,winners,best,loser):
            """ Build and display the input window """
            self.winners = winners
            if win == 'draw':
                increaser = 0
                counter = 0

                self.win = win = GraphWin("Black Jack: Game Over!", 500, 500)
                win.setCoords(0,4.5,4,.5)

                Text(Point(2,.7), "GAME OVER! Draw").draw(win)
                
                Text(Point(1,1), "Winner").draw(win)
                entry1 = Entry(Point(3,1), 8).draw(win)
                entry1.setText("Dealer")

                for i in winners:
                    Text(Point(1,1.5+increaser), "Winner").draw(win)
                    entry = Entry(Point(3,1.5+increaser), 8).draw(win)
                    entry.setText(str(winners[0+counter]))
                    increaser += .5
                    counter += 1
                    
                Text(Point(1,3.5), "Draw Score").draw(win)
                entry = Entry(Point(3,3.5), 8).draw(win)
                entry.setText(str(best))



                self.quit = Button(win, Point(2,4), 1.25, .5, "Quit")
                self.quit.activate()
                
            elif win == 'dealer':
                self.win = win = GraphWin("Black Jack", 500, 500)
                win.setCoords(0,4.5,4,.5)

                Text(Point(2,1), "GAME OVER! Dealer Had Highest Score").draw(win)
                
                Text(Point(1,1.5), "Winner").draw(win)
                entry = Entry(Point(3,1.5), 8).draw(win)
                entry.setText("Dealer")
                
                Text(Point(1,3.5), "Highest Score: Dealer").draw(win)
                entry = Entry(Point(3,3.5), 8).draw(win)
                entry.setText(str(best))
                
                self.quit = Button(win, Point(2,4), 1.25, .5, "Quit")
                self.quit.activate()
                
            elif win == 'players':
                increaser = 0
                counter = 0
                self.win = win = GraphWin("Black Jack", 500, 500)
                win.setCoords(0,4.5,4,.5)

                Text(Point(2,1), "GAME OVER! Player(s) had Highest Score").draw(win)
    
                
                for i in winners:
                    Text(Point(1,2+increaser), "Winner").draw(win)
                    entry = Entry(Point(3,2+increaser), 8).draw(win)
                    entry.setText(str(winners[0+counter]))
                    increaser += .5
                    counter += 1
                    
                Text(Point(1,3.5), "Highest Score: Player").draw(win)
                entry = Entry(Point(3,3.5), 8).draw(win)
                entry.setText(str(best))
                    
                self.quit = Button(win, Point(2,4), 1.25, .5, "Quit")
                self.quit.activate()
                

        def update(self,players,hands):
            """ return input values """
            increaser = 0
            counter = 0
            for i in players:
                entry = Entry(Point(3,1.5+increaser), 5).draw(self.win)
                hand = hands[0+counter]
                entry.setText(str(hand))
                increaser += .5
                counter += 1

        def interact(self):
            """ wait for user to click Quit or Fire button
            Returns a string indicating which button was clicker
            """

            while True:
                pt = self.win.getMouse()
                if self.quit.clicked(pt):
                    return "Quit"

        def close(self):
            """ close the input window """
            self.win.close()

class InputDialog2:

    """ A custom window for getting simulation values (angle, velocity,
    and height) from the user."""

    def __init__(self, players,hands = 0, players_ent = 0):
        """ Build and display the input window """
        increaser = 0
                   
        self.win = win = GraphWin("Black Jack", 500, 500)
        win.setCoords(0,4.5,4,.5)
        
        player_count = len(players)
        Text(Point(1,1), "Players").draw(win)
        self.players_ent = Entry(Point(3,1), 5).draw(win)
        self.players_ent.setText(str(player_count))
        
        self.players = players

        
        for i in self.players:
            Text(Point(1,1.5+increaser), "Hands").draw(win)
            entry = Entry(Point(3,1.5+increaser), 5).draw(win)
            hand = 0
            entry.setText(str(hand))
            increaser += .5


        self.hand = Button(win, Point(1,4), 1.25, .5, "Hand")
        self.hand.activate()

        self.quit = Button(win, Point(3,4), 1.25, .5, "Quit")
        self.quit.activate()

    def update(self,players,hands):
        """ return input values """
        increaser = 0
        counter = 0
        for i in players:
            entry = Entry(Point(3,1.5+increaser), 5).draw(self.win)
            hand = hands[0+counter]
            entry.setText(str(hand))
            increaser += .5
            counter += 1

    def interact(self):
        """ wait for user to click Quit or Fire button
        Returns a string indicating which button was clicker
        """
        
        while True:
            pt = self.win.getMouse()
            if self.quit.clicked(pt):
                return "Quit"
            if self.hand.clicked(pt):
                return "Hand"

    def close(self):
        """ close the input window """
        self.win.close()

class ShowHand:

    """ A custom window for getting simulation values (angle, velocity,
    and height) from the user."""

    def __init__(self, player,hands = 0, players_ent = 0):
        """ Build and display the input window """
                   
        self.win = win = GraphWin("Black Jack", 500, 500)
        win.setCoords(0,4.5,4,.5)
        
        Text(Point(1,1), "Player").draw(win)
        p_ent = Entry(Point(3,1), 7).draw(win)
        p_ent.setText(str(player))
        
        self.player = player

        
        Text(Point(1,2), "Hand").draw(win)
        entry = Entry(Point(3,2), 5).draw(win)
        hand = 0
        entry.setText(str(hand))


        self.hand = Button(win, Point(1,4), 1.25, .5, "Hand")
        self.hand.activate()

        self.done = Button(win, Point(3,4), 1.25, .5, "Done")
        self.done.activate()

    def update(self,players,hands):
        """ return input values """
        
        Text(Point(1,1), "Player").draw(self.win)
        player_ent = Entry(Point(3,1), 7).draw(self.win)
        player_ent.setText(str(players))
        
        entry = Entry(Point(3,2), 5).draw(self.win)
        hand = hands
        entry.setText(str(hand))


    def interact(self):
        """ wait for user to click Quit or Fire button
        Returns a string indicating which button was clicker
        """
        
        while True:
            pt = self.win.getMouse()
            if self.done.clicked(pt):
                return "Done"
            if self.hand.clicked(pt):
                return "Hand"
            
    def over(self):
        while True:
            pt = self.win.getMouse()
            if self.done.clicked(pt):
                return "Done"
            if self.hand.clicked(pt):
                return "Hand"
        

    def close(self):
        """ close the input window """
        self.win.close()

class GameOver:
    
        def __init__(self,end,winners,players=0):
            """ Build and display the input window """
            self.winners = winners
            if winners != "dealer" and end != 'draw':
                increaser = 0
                counter = 0

                self.win = win = GraphWin("Black Jack: Game Over!", 500, 500)
                win.setCoords(0,4.5,4,.5)

                Text(Point(2,1), "GAME OVER! 21 Hit").draw(win)

                for i in winners:
                    Text(Point(1,1.5+increaser), "Winner").draw(win)
                    entry = Entry(Point(3,1.5+increaser), 8).draw(win)
                    entry.setText(str(winners[0+counter]))
                    increaser += .5
                    counter += 1



                self.quit = Button(win, Point(2,4), 1.25, .5, "Quit")
                self.quit.activate()
                
            elif winners == 'dealer':
                self.win = win = GraphWin("Black Jack", 500, 500)
                win.setCoords(0,4.5,4,.5)

                Text(Point(2,1), "GAME OVER! 21 Hit by Dealer").draw(win)
                
                Text(Point(1,1.5), "Winner").draw(win)
                entry = Entry(Point(3,1.5), 8).draw(win)
                entry.setText("Dealer")
                
                self.quit = Button(win, Point(2,4), 1.25, .5, "Quit")
                self.quit.activate()
                
            elif end == 'draw':
                increaser = 0
                counter = 0
                self.win = win = GraphWin("Black Jack", 500, 500)
                win.setCoords(0,4.5,4,.5)

                Text(Point(2,1), "GAME OVER! 21 Hit & Draw").draw(win)
                
                Text(Point(1,1.5), "Winner").draw(win)      
                entryDeal = Entry(Point(3,1.5), 8).draw(win)
                entryDeal.setText('Dealer')
                
                for i in winners:
                    Text(Point(1,2+increaser), "Winner").draw(win)
                    entry = Entry(Point(3,2+increaser), 8).draw(win)
                    entry.setText(str(winners[0+counter]))
                    increaser += .5
                    counter += 1
                    
                self.quit = Button(win, Point(2,4), 1.25, .5, "Quit")
                self.quit.activate()
                

        def update(self,players,hands):
            """ return input values """
            increaser = 0
            counter = 0
            for i in players:
                entry = Entry(Point(3,1.5+increaser), 5).draw(self.win)
                hand = hands[0+counter]
                entry.setText(str(hand))
                increaser += .5
                counter += 1

        def interact(self):
            """ wait for user to click Quit or Fire button
            Returns a string indicating which button was clicker
            """

            while True:
                pt = self.win.getMouse()
                if self.quit.clicked(pt):
                    return "Quit"
                if self.hand.clicked(pt):
                    return "Hand"

        def close(self):
            """ close the input window """
            self.win.close()

class DealerHand():
    """ A custom window for getting simulation values (angle, velocity,
    and height) from the user."""

    def __init__(self, dealer_hand,dealer_card1):
        """ Build and display the input window """
                   
        self.win = win = GraphWin("Black Jack: Dealer Hand", 500, 500)
        win.setCoords(0,4.5,4,.5)
        
        Text(Point(1,1), "Dealer's Hand").draw(win)
        p_ent = Entry(Point(3,1), 7).draw(win)
        p_ent.setText("???")
        
        
        deal_card = Text(Point(1,2), "Dealer Card 1").draw(win)
        deal_card.setStyle('bold')
        deal_card.setSize(20)
        entry = Entry(Point(3,2), 5).draw(win)
        entry.setText(str(dealer_card1))
        entry.setStyle('bold')
        
        Text(Point(1,3), "Hidden Card").draw(win)
        entry = Entry(Point(3,3), 5).draw(win)
        entry.setText("???")

        self.done = Button(win, Point(2,4), 1.25, .5, "Done")
        self.done.activate()


    def interact(self):
        """ wait for user to click Quit or Fire button
        Returns a string indicating which button was clicker
        """
        
        while True:
            pt = self.win.getMouse()
            if self.done.clicked(pt):
                return "Done"
            
    def over(self):
        while True:
            pt = self.win.getMouse()
            if self.done.clicked(pt):
                return "Done"
            if self.hand.clicked(pt):
                return "Hand"
        

    def close(self):
        """ close the input window """
        self.win.close()
    

class AddingCards():
    
    """ A custom window for getting simulation values (angle, velocity,
    and height) from the user."""

    def __init__(self, player,hand,new_card="N/A", players_ent = 0):
        """ Build and display the input window """
                   
        self.win = win = GraphWin("Black Jack Adding Cards", 500, 500)
        win.setCoords(0,4.5,4,.5)
        
        Text(Point(1,1), "Player").draw(win)
        p_ent = Entry(Point(3,1), 7).draw(win)
        p_ent.setText(str(player))
        
        self.player = player

        
        Text(Point(1,2), "New Card").draw(win)
        entry = Entry(Point(3,2), 5).draw(win)
        entry.setText(str(new_card))
        
        Text(Point(1,3), "Hand").draw(win)
        entry = Entry(Point(3,3), 5).draw(win)
        entry.setText(str(hand))


        self.add = Button(win, Point(1,4), 1.25, .5, "Add")
        self.add.activate()

        self.done = Button(win, Point(3,4), 1.25, .5, "Done")
        self.done.activate()

    def update(self,players,hands,new_card=0):
        """ return input values """
        
        Text(Point(1,1), "Player").draw(self.win)
        player_ent = Entry(Point(3,1), 7).draw(self.win)
        player_ent.setText(str(players))
        
        entry = Entry(Point(3,2), 5).draw(self.win)
        entry.setText(str(new_card))
        
        entry = Entry(Point(3,3), 5).draw(self.win)
        hand = hands
        entry.setText(str(hand))
        
        if hand > 21:
            bustText = Text(Point(2,3.5), "BUSTED!!").draw(self.win)
            bustText.setStyle("bold")
            bustText.setSize(20)
        elif hand == 21:
            winText = Text(Point(2,3.5), "21!!").draw(self.win)
            winText.setStyle("bold")
            winText.setSize(20)
    

    def interact(self):
        """ wait for user to click Quit or Fire button
        Returns a string indicating which button was clicker
        """
        
        while True:
            pt = self.win.getMouse()
            if self.done.clicked(pt):
                return "Done"
            if self.add.clicked(pt):
                return "Add"
            
    def over(self):
        while True:
            pt = self.win.getMouse()
            if self.done.clicked(pt):
                return "Done"
            if self.hand.clicked(pt):
                return "Hand"
        

    def close(self):
        """ close the input window """
        self.win.close()
