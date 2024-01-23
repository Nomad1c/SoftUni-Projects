budget = float(input())
season = input()

destination = ""
vacation_type = ""
spent_money = 0

if budget <= 100:
    destination = "Bulgaria"
    if season == "summer":
        vacation_type = "Camp"
        spent_money = budget * 0.3
    elif season == "winter":
        vacation_type = "Hotel"
        spent_money = budget * 0.7
elif 100 < budget <= 1000:
    destination = "Balkans"
    if season == "summer":
        vacation_type = "Camp"
        spent_money = budget * 0.4
    elif season == "winter":
        vacation_type = "Hotel"
        spent_money = budget * 0.8
elif budget > 1000:
    destination = "Europe"
    vacation_type = "Hotel"
    spent_money = budget * 0.9

print(f"Somewhere in {destination}")
print(f"{vacation_type} - {spent_money:.2f}")
