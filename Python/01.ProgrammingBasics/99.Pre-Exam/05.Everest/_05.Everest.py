height = 5364
top = 8848
input_string = input()
up = int(input())
days = 1

while True:
    if input_string != "END":
        height += up

    if input_string == "Yes":
        days += 1

    if input_string == "END" or days >= 5 or height >= top:
        break

    input_string = input()

    if input_string != "END":
        up = int(input())

if top > height:
    print("Failed!")
    print(f"{height}")
else:
    print(f"Goal reached for {days} days!")
