# Global Variables
import random
from IPython.display import clear_output
import time

values = {'Acelow':1, 'Two':2, 'Three':3, 'Four':4, 'Five':5, 'Six':6, 'Seven':7, 'Eight':8, 
            'Nine':9, 'Ten':10, 'Jack':10, 'Queen':10, 'King':10, 'Ace':11}

suits = ('Hearts', 'Diamonds', 'Spades', 'Clubs')

ranks = ('Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine', 'Ten', 'Jack', 'Queen', 'King', 'Ace')

class Card():
    """
    Class that represents cards, they each have a suit and rank
    """
    
    def __init__(self,suit,rank):
        self.suit = suit
        self.rank = rank
        self.value = values[self.rank.capitalize()]
        
    def __str__(self):
        return f"{self.rank.capitalize()} of {self.suit}"
    
    def ace(self,modifier= 'no'):
        if modifier.lower() == 'yes':
            self.rank = "Acelow"
            self.value = values[self.rank.capitalize()]

class Deck():
    """
    Class that represents a deck of cards, will have 52 cards like a standard deck
    """
    
    def __init__(self):
        
        self.cards = []
        
        for suit in suits:
            for rank in ranks:
                card = Card(suit,rank)
                self.cards.append(card)
                
    def shuffle(self):
        random.shuffle(self.cards)
        
    def deal(self):
        return self.cards.pop(0)
    
    def __str__(self):
        return f"Deck of {len(self.cards)} cards"
    
class Player():
    """
    Class that represents the player, they have a hand and can have cards added and can show their hand and hand value
    """
    
    def __init__(self, name, chips=0):
        self.name = name
        self.hand = []
        self.chips = chips
        self.hand_list = []
        self.value_hand = 0
        
    def add_to_hand(self, added_card):
        self.hand.append(added_card)

        
    def special_display(self):
        self.hand_list = []
        for card in self.hand:
            self.hand_list.append(str(card))
        return f"{str(self.hand_list[0])} and Hidden Card"
        
        
    def display_hand(self):
        self.hand_list = []
        for card in self.hand:
            self.hand_list.append(str(card))
        return f"{str(self.hand_list)}"

    
    def __str__(self):
        self.hand_list = []
        for card in self.hand:
            self.hand_list.append(str(card))
        return f"Player: {self.name} has cards {str(self.hand_list)} and {self.chips} chips"
    
    def hand_value(self):
        self.value_hand = 0
        for card in self.hand:
            self.value_hand += card.value
        return self.value_hand

def set_up_game():


    """
    Initializes the game by creating a player and a dealer with the "Player" class
    """

    # Get's player's name and sets up the player variable, chips stay at 10 to start
    name = input("What's your name? ")
    player = Player(name, 10)

    # Set's up the dealer variable
    dealer = Player('Dealer')

    # Sets up the deck variable
    deck = Deck()
    deck.shuffle()

    # Introduces game
    print(f"Let's play Black Jack {player.name} you have {player.chips} chips")
    print(f"Good Luck against the {dealer.name}")
    clear_output(True)
    time.sleep(2)

    return player,dealer,deck

def continue_game(info_name,info_chips):
    """
    Runs if player is playing once again, ends the game if they are out of chips, otherwise resets the player,dealer,and deck
    """

    # If they player has no more chips the game ends
    if info_chips <= 0:
        print(f"Sorry {info_name} you are out of chips! Game Over")
    else:
        # Clears all old output from last game
        clear_output(True)
        time.sleep(2)
        stopper = "Time.sleep is broken..."
        
        # Resets player, dealer and deck variables
        deck = Deck()
        deck.shuffle()
        dealer = Player("Dealer")
        player = Player(info_name,info_chips)
        print(f"New Round! {info_name} you have {info_chips} chips left")
            
        return player,dealer,deck
    
def give_inital_hands(player,dealer,deck):
    """
    Provides initial two cards to player and dealer
    """
    
    # Gives the player and dealer their first two cards
    for i in range(2):
        dealer.add_to_hand(deck.deal())
        player.add_to_hand(deck.deal())
        
    # Shows the player their cards and the dealer's first card
    print(f"{player.name}'s hand {player.display_hand()} value is {player.hand_value()}")
    print(f"{dealer.name}'s hand {dealer.special_display()} value is {dealer.hand_value() - dealer.hand[1].value}")
    print("\n")


def final_check(player,dealer,wager_amount):
    """
    Compares the dealer and player's card after both haven't busted to determine final outcome
    """
    
    print(f"{dealer.name} hit 17 or above and stopped for a total value of {dealer.hand_value()}")
    time.sleep(2)
    
    # If the player's hand is larger they win
    if player.hand_value() > dealer.hand_value():
        print(f"{player.name}'s hand value: {player.hand_value()} || {dealer.name}'s hand value: {dealer.hand_value()}")
        print(f"{player.name} you won! with a hand of {player.hand_list} and value of {player.hand_value()}")
        player.chips += wager_amount * 2
        print(f"Congratz {player.name}! You Won {wager_amount*2} chips!")
        
    # If the dealer's hand is larger they win
    elif player.hand_value() < dealer.hand_value():
        print(f"{player.name}'s hand value: {player.hand_value()} || {dealer.name}'s hand value: {dealer.hand_value()}")
        print(f"{dealer.name} you won! with a hand of {dealer.hand_list} and value of {dealer.hand_value()}")
        print(f"Sorry {player.name}! You lost {wager_amount} chips!")
        
    # If they draw give the player their chips back
    elif player.hand_value() == dealer.hand_value():
        print("There was a draw")
        print(f"{player.name} you got back your {wager_amount} chips.")
        player.chips += wager_amount

def initial_deal(player,dealer,deck,wager_amount):
    """
    Does the inital dealing of cards to the player, they can decide to get more cards or stay, also checks if they busted
    """
    
    dealing = True
    play_game = None
    
    # Has the player decide to hit or stay and should they bust or hit 21 ends game
    while dealing:
        ace_check_normal(player)
        
        # Checks and ends game should player bust
        if player.hand_value() > 21:
            print(f"{player.name} sorry you BUSTED! and lost {wager_amount} chips!")
            print(f"{dealer.name} Wins!")
            play_game = False
            dealing = False
            break
            
        # Checks and ends game if player gets black jack
        elif player.hand_value() == 21:
            print(f"{player.name} you hit Black Jack! You Win! You won {wager_amount*2} chips!")
            player.chips += wager_amount * 2
            play_game = False
            dealing = False
            break
        
        # Asks player if they'd like to hit or stay
        choice = input("Would you like to hit or stay? ")
        if choice.lower() == 'hit':
            player.add_to_hand(deck.deal())
            print(f"{player.name}'s hand is now {player.display_hand()} value is {player.hand_value()}")
            
        elif choice.lower() == 'stay':
            print("\n")
            play_game = True
            dealing = False
            break
            
    return play_game

def ace_check_normal(player):
    """
    In the event a player has over 21 in values, this function will reduce their aces to 1s rather than 11s
    """
    
    total = player.hand_value()
    hand_ranks = []

    # Finds if player has any aces in their hand
    for card in player.hand:
        hand_ranks.append(card.rank)
    
    # If aces are drawn and it busts the player, the aces are reduced to 1
    if total > 21 and "Ace" in hand_ranks:
        for card in player.hand:
            if card.value == 11:
                card.ace('yes')
                
        print(f"{player.name}'s Ace was reduced to 1'")
        print(f"{player.name}'s hand is now {player.display_hand()} value is {player.hand_value()}")
        player.hand_value()

def ace_check_initial(player):
    """
    Should a player get an ace they can decide if it'll be worth 1 or 11, they they get two aces it reduces the first to 1
    """
    
    total = player.hand_value()
    hand_ranks = []
    keep_asking = True
    

        
    
    # If the player has two aces the first is reduced to one
    if player.hand_value() == 22:
        change_card = player.hand[0]
        change_card.ace('yes')
        player.hand[0] = change_card
        
    for card in player.hand:
        hand_ranks.append(card.rank)
    
    # If its the dealer their ace will automatically be 11
    if player.name.lower() == 'dealer':
        pass
    

    # Otherwise the player can decide if their ace will be 1 or 11
    else:
        if "Ace" in hand_ranks and "Acelow" not in hand_ranks and player.hand_value() != 21:
            while keep_asking == True:
                player_choice = input("Would you like your Ace to be 11 0r 1? ")
                try:
                    if int(player_choice) == 1:
                        for card in player.hand:
                            if card.value == 11:
                                card.ace('yes')
                                
                        print("Ace is 1")
                        print(f"{player.name}'s hand is now {player.display_hand()} value is {player.hand_value()}")
                        keep_playing = False
                        break
                        
                    elif int(player_choice) == 11:
                        print("Ace is 11")
                        print(f"{player.name}'s hand is now {player.display_hand()} value is {player.hand_value()}")
                        keep_playing = False
                        break
                except:
                    print("Please select either 11 or 1!")

def dealer_play(player,dealer,deck,wager_amount):
    """
    Has the dealer draw cards until hitting 17 or higher and checks if they busted
    """
    play_game = True
    
    # If the dealer is below 17 they must draw cards until hitting 17 or higher
    while dealer.hand_value() < 17:
        print(f"{dealer.name} is below 17, will now draw cards")
        time.sleep(2)
        dealer.add_to_hand(deck.deal())
        dealer.hand_value()
        print(f"{dealer.name} added {dealer.hand[-1]} for a total value of {dealer.hand_value()}")
        
    # Checks for aces and reduces them to ones if the dealer's card values total over 21   
        ace_check_normal(dealer)
        dealer.hand_value()

    # VERY NEW
    if dealer.hand_value() == 21:
        print(f"{dealer.name} got 21! BlackJack!")
        print(f"{player.name} sorry you BUSTED! and lost {wager_amount} chips!")
        player.chips -= wager_amount
        play_game = False
    
    # Checks if the dealer busted and if so ends the game
    if dealer.hand_value() > 21:
        print(f"{dealer.name} BUSTED!")
        player.chips += wager_amount * 2
        print(f"Congratz {player.name}! You Won {wager_amount*2} chips!")
        play_game = False
 
    return play_game

def wager(player):
    
    """
    Has the player make a wager with their chips to play black jack
    """
    
    wager_amount = 0
    trying = True
    
    # checks if the player has enough chips to keep playing
    if player.chips <= 0:
        print("Sorry you don't have enough chips to play!")
        print("GAME OVER")
        
        return wager_amount
    
    else:
        # If the player has chips: will ask for a valid wager amount
        while trying:
            try:
                wager_amount = int(input(f"{player.name} how many chips will you wager? (You have {player.chips} chips): "))
                if wager_amount > player.chips:
                    print("You don't have enough chips for that wager!")
                    
                elif wager_amount == 0:
                    print("You must wager at least one chip to play!")
                    
                else:
                    trying = False
                    break
            except:
                print("Only enter a whole number! (e.g. 10,20) ")
                
    # Removes the betted chips from the player           
    player.chips -= wager_amount
    
    return wager_amount

def black_jack(replay = False, info_name = None, info_chips = None):
    """
    Function that runs the Black Jack game
    """
    
    # Get player, dealer and deck variables to start game
    # if replay is false its the first game and gets the player's info
    # if replay is True it gets the player's info from the previous game
    if replay == False:
        player,dealer,deck = set_up_game()
    else:
        player,dealer,deck = continue_game(info_name, info_chips)
    
    # Get's the player's wager amount
    wager_amount = wager(player)
    
    # If the player doesn't have chips the game ends, otherwise we continue
    if wager_amount > 0:
        play_game = True

        # Gives the player and dealer their intial two cards
        give_inital_hands(player,dealer,deck)

        # If Player has an Ace they choose if its an 11 or 1
        ace_check_initial(player)

        # Player can choose to hit or stay; if they go over 21 they bust, if they hit 21 they win
        while play_game == True:
            play_game = initial_deal(player,dealer,deck,wager_amount)
            
            if play_game == False:
                return player.name,player.chips
                break

            # Player is done and dealer's full hand is revealed
            print(f"Dealer Flipped their hidden card!")
            print(f"{dealer.name}'s hand {dealer.display_hand()} value is {dealer.hand_value()}")
            print("\n")

            # Checks if the dealer gets an ace and sets it to 11, if they have two aces one is 11 and the other 1
            time.sleep(2)
            ace_check_initial(dealer)

            # Player is done and hasn't busted,now the dealer must draw until hitting 17 or higher
            play_game = dealer_play(player,dealer,deck,wager_amount)
            time.sleep(2)
            clear_output(True)
            
            if play_game == False:
                return player.name,player.chips
                break

            # If dealer didn't bust a final comparison is made to see who has the lager value   
            final_check(player,dealer,wager_amount)
            play_game = False
            
            # returns the player's name and chip amount for further iterations
            return player.name,player.chips

    else:
        print("GAME OVER")

def main():
    """
    Main function that runs and re-runs blackjack should the player want to continue
    """
    
    still_in = True
    replay = False
    info_name = None
    info_chips = None
    
    # starts and will restart the game if the player wishes to play again
    while still_in:
        info_name,info_chips = black_jack(replay,info_name,info_chips)
        info_name = info_name
        info_chips = info_chips
        attempting = True
        
        # The game has ended and will see if the player wants to play again (if they have chips left)
        while attempting:
            try:
                # If they are out of chips the game ends
                if info_chips == 0:
                    print("No more chips left! Game Over!")
                    still_in = False
                    attempting = False
                    break
                    
                # Asks if player wants to play again
                else:
                    # starts new game
                    response = input(f"Do you want to play again (Y or N) ? you still have {info_chips} chips? ")
                    if response.upper() == "Y":
                        replay = True
                        still_in = True
                        attempting = False
                        break
                        
                    # ends game    
                    elif response.upper() == "N":
                        print("Thanks for Playing!")
                        print(f"{info_name} you walk away with {info_chips} chips!")
                        still_in = False
                        attempting = False
                        break
            except:
                print("Sorry that wasn't either Y or N, try again!")


main()