party_price = float(input())
love_letters = int(input())
wax_roses = int(input())
keychains = int(input())
caricatures = int(input())
luck_surprises = int(input())

total_price = love_letters * 0.60 + wax_roses * 7.20 + keychains * 3.60 + caricatures * 18.20 + luck_surprises * 22

total_items = love_letters + wax_roses + keychains + caricatures + luck_surprises

if total_items >= 25:
    discount = 0.35 * total_price
    total_price -= discount

hosting_expenses = 0.10 * total_price
profit = total_price - hosting_expenses

if profit >= party_price:
    left_money = "{:.2f}".format(profit - party_price)
    print(f"Yes! {left_money} lv left.")
else:
    needed_money = "{:.2f}".format(party_price - profit)
    print(f"Not enough money! {needed_money} lv needed.")
