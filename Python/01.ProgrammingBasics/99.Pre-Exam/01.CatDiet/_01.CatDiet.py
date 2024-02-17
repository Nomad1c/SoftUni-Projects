
fat_percentage = int(input())
protein_percentage = int(input())
carbohydrate_percentage = int(input())
total_calories = int(input())
water_percentage = int(input())

fat_grams = (fat_percentage / 100) * total_calories / 9
protein_grams = (protein_percentage / 100) * total_calories / 4
carbohydrate_grams = (carbohydrate_percentage / 100) * total_calories / 4

total_weight = fat_grams + protein_grams + carbohydrate_grams

water_calories = (water_percentage / 100) * total_calories
calories_per_gram = total_calories / total_weight
calories_per_gram_without_water = calories_per_gram - (water_calories / total_weight)

print(f"{calories_per_gram_without_water:.4f}")
