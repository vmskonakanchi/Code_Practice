import random as R
suits = ('Hearts', 'Diamonds', 'Spades', 'Clubs')
ranks = ('Two', 'Three', 'Four', 'Five', 'Six', 'Seven',
         'Eight', 'Nine', 'Ten', 'Jack', 'Queen', 'King', 'Ace')
values = {'Two': 2, 'Three': 3, 'Four': 4, 'Five': 5, 'Six': 6, 'Seven': 7,
          'Eight': 8, 'Nine': 9, 'Ten': 10, 'Jack': 10, 'Queen': 10, 'King': 10, 'Ace': 11}


class Card:
    def __init__(self, suit, rank):
        self.suit = suit
        self.rank = rank

    def __str__(self) -> str:
        return f"{self.suit} of {self.rank}"


class Deck():
    def __init__(self):
        self.deck = []
        for st in suits:
            for rk in ranks:
                self.deck.append(Card(st, rk))


    def __str__(self) -> str:
        deck_comp = ""
        for d in self.deck:
            deck_comp += "\n" + d.__str__()
        return "The deck has :" + deck_comp

    def shuffle(self):
        R.shuffle(self.deck)

    def pop(self):
        return self.deck.pop()


class Hand():
    def __init__(self):
        self.cards = []
        self.value = 0
        self.aces = 0

    def add_card(self, card):
        self.cards.append(card)
        self.value += values[card.rank]

    def adjust_for_ace(self):
        pass

test_deck = Deck()
test_deck.shuffle()
test_player = Hand()
test_player.add_card(test_deck.pop())
test_player.add_card(test_deck.pop())
for p in test_player.cards:
    print(p)
