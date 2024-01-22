budget = float(input())
statisticians_count = int(input())
clothing_price_per_statistician = float(input())

decor_price = budget * 0.10
clothing_price = statisticians_count * clothing_price_per_statistician

if statisticians_count > 150:
    clothing_price -= clothing_price * 0.10

total_cost = decor_price + clothing_price

if total_cost > budget:
    needed_money = total_cost - budget
    print("Not enough money!")
    print(f"Wingard needs {needed_money:.2f} leva more.")
else:
    money_left = budget - total_cost
    print("Action!")
    print(f"Wingard starts filming with {money_left:.2f} leva left.")
