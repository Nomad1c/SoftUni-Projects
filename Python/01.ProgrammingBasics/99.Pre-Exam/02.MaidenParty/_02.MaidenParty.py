
def calculate_profit(input_list):
    party_budget = float(input_list[0])
    love_messages = int(input_list[1])
    wax_roses = int(input_list[2])
    keychains = int(input_list[3])
    caricatures = int(input_list[4])
    lucky_surprises = int(input_list[5])

    love_message_price = 0.60
    wax_rose_price = 7.20
    keychain_price = 3.60
    caricature_price = 18.20
    lucky_surprise_price = 22.00

    total_price = (love_messages * love_message_price) + (wax_roses * wax_rose_price) + \
                  (keychains * keychain_price) + (caricatures * caricature_price) + \
                  (lucky_surprises * lucky_surprise_price)

    discount = 0.35 if love_messages + wax_roses + keychains + caricatures + lucky_surprises >= 25 else 0

    total_price -= total_price * discount
    hosting_expenses = total_price * 0.10
    total_price -= hosting_expenses

    remaining_money = abs(party_budget - total_price)

    if total_price <= party_budget:
        return f"Yes! {remaining_money:.2f} lv left."
    else:
        return f"Not enough money! {remaining_money:.2f} lv needed."


input_data1 = ["40.8", "20", "25", "30", "50", "10"]
input_data2 = ["320", "8", "2", "5", "5", "1"]

print(calculate_profit(input_data1))
print(calculate_profit(input_data2))
