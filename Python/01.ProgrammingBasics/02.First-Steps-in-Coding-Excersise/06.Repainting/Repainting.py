nylon_quantity = int(input())
paint_quantity = int(input())
thinner_quantity = int(input())
hours_of_work = int(input())

nylon_price_per_sqm = 1.50
paint_price_per_liter = 14.50
thinner_price_per_liter = 5.00
bags_price = 0.40

nylon_cost = (nylon_quantity + 2) * nylon_price_per_sqm
paint_cost = (paint_quantity + paint_quantity * 0.10) * paint_price_per_liter
thinner_cost = thinner_quantity * thinner_price_per_liter
bags_cost = bags_price

total_material_cost = nylon_cost + paint_cost + thinner_cost + bags_cost

labor_cost = total_material_cost * 0.30 * hours_of_work

total_cost = total_material_cost + labor_cost

print(f'{total_cost:.2f}')
