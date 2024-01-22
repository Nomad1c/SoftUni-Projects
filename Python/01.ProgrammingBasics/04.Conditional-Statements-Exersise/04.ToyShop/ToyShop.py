excursion_price = float(input())
puzzles_count = int(input())
dolls_count = int(input())
teddy_bears_count = int(input())
minions_count = int(input())
trucks_count = int(input())

total_toys = puzzles_count + dolls_count + teddy_bears_count + minions_count + trucks_count
total_money = puzzles_count * 2.60 + dolls_count * 3 + teddy_bears_count * 4.10 + minions_count * 8.20 + trucks_count * 2

if total_toys >= 50:
    total_money -= total_money * 0.25

total_money -= total_money * 0.10  # Rent
money_left = total_money - excursion_price

if money_left >= 0:
    print(f"Yes! {money_left:.2f} lv left.")
else:
    print(f"Not enough money! {abs(money_left):.2f} lv needed.")
