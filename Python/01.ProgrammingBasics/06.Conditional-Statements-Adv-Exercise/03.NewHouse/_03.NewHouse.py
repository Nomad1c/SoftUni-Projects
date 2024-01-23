flower_type = input()
flower_count = int(input())
budget = int(input())

flower_prices = {
    "Roses": 5.00,
    "Dahlias": 3.80,
    "Tulips": 2.80,
    "Narcissus": 3.00,
    "Gladiolus": 2.50
}

total_cost = flower_count * flower_prices[flower_type]

if flower_type == "Roses" and flower_count > 80:
    total_cost *= 0.90
elif flower_type == "Dahlias" and flower_count > 90:
    total_cost *= 0.85
elif flower_type == "Tulips" and flower_count > 80:
    total_cost *= 0.85
elif flower_type == "Narcissus" and flower_count < 120:
    total_cost *= 1.15
elif flower_type == "Gladiolus" and flower_count < 80:
    total_cost *= 1.20

if budget >= total_cost:
    left_money = budget - total_cost
    print(f"Hey, you have a great garden with {flower_count} {flower_type} and {left_money:.2f} leva left.")
else:
    needed_money = total_cost - budget
    print(f"Not enough money, you need {needed_money:.2f} leva more.")
