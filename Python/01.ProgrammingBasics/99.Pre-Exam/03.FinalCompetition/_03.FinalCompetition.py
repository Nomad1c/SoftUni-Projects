dancers = int(input())
points = float(input())
season = input()
location = input()

prize_money = dancers * points

if location == "Abroad":
    prize_money += 0.50 * prize_money

if season == "summer":
    expenses_percentage = 0.10 if location == "Abroad" else 0.05
else:
    expenses_percentage = 0.15 if location == "Abroad" else 0.08

prize_money -= expenses_percentage * prize_money

charity_money = 0.75 * prize_money
remaining_money = prize_money - charity_money
money_per_dancer = remaining_money / dancers

print(f"Charity - {charity_money:.2f}")
print(f"Money per dancer - {money_per_dancer:.2f}")
