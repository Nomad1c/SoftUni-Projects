pens = int(input())
markers = int(input())
cleaner_liters = int(input())
discount_percent = int(input())

pen_price = 5.80
marker_price = 7.20
cleaner_price_per_liter = 1.20

total_price = (pens * pen_price) + (markers * marker_price) + (cleaner_liters * cleaner_price_per_liter)

discount = total_price * (discount_percent / 100)
final_price = total_price - discount

print(f'{final_price:.2f}')
