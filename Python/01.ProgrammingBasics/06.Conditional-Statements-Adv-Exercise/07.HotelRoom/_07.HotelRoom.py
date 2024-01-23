month = input()
nights = int(input())

apartment_price = 0
studio_price = 0

if month == "May" or month == "October":
    apartment_price = 65 * nights
    studio_price = 50 * nights
    if nights > 14:
        studio_price *= 0.70
        apartment_price *= 0.90
    elif nights > 7:
        studio_price *= 0.95
elif month == "June" or month == "September":
    apartment_price = 68.70 * nights
    studio_price = 75.20 * nights
    if nights > 14:
        studio_price *= 0.80
        apartment_price *= 0.90
elif month == "July" or month == "August":
    apartment_price = 77 * nights
    studio_price = 76 * nights
    if nights > 14:
        apartment_price *= 0.90

print(f"Apartment: {apartment_price:.2f} lv.")
print(f"Studio: {studio_price:.2f} lv.")
