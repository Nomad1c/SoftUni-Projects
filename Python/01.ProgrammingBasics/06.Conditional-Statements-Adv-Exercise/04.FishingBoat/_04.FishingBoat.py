budget = int(input())
season = input()
fishermen_count = int(input())

boat_rental_prices = {
    "Spring": 3000,
    "Summer": 4200,
    "Autumn": 4200,
    "Winter": 2600
}

discounts = {
    "up_to_6": 0.10,
    "7_to_11": 0.15,
    "12_and_above": 0.25
}

boat_rental = boat_rental_prices[season]
discount = 0

if fishermen_count <= 6:
    discount = discounts["up_to_6"]
elif 7 <= fishermen_count <= 11:
    discount = discounts["7_to_11"]
else:
    discount = discounts["12_and_above"]

total_cost = boat_rental - (boat_rental * discount)

if fishermen_count % 2 == 0 and season != "Autumn":
    total_cost *= 0.95

if budget >= total_cost:
    left_money = budget - total_cost
    print(f"Yes! You have {left_money:.2f} leva left.")
else:
    needed_money = total_cost - budget
    print(f"Not enough money! You need {needed_money:.2f} leva.")
