days = int(input())
room_type = input()
rating = input()

nights = days - 1
room_price = 0

if room_type == "room for one person":
    room_price = 18.00 * nights
elif room_type == "apartment":
    room_price = 25.00 * nights
    if 10 <= days <= 15:
        room_price *= 0.65
    elif days > 15:
        room_price *= 0.5
elif room_type == "president apartment":
    room_price = 35.00 * nights
    if 10 <= days <= 15:
        room_price *= 0.9
    elif days > 15:
        room_price *= 0.8

if rating == "positive":
    room_price += room_price * 0.25
elif rating == "negative":
    room_price -= room_price * 0.1

print(f"{room_price:.2f}")
