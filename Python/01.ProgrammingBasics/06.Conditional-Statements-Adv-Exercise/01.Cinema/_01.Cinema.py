projection_type = input()
rows = int(input())
columns = int(input())

ticket_price = 0

if projection_type == "Premiere":
    ticket_price = 12.00
elif projection_type == "Normal":
    ticket_price = 7.50
elif projection_type == "Discount":
    ticket_price = 5.00

total_income = rows * columns * ticket_price

print(f"{total_income:.2f} leva")
