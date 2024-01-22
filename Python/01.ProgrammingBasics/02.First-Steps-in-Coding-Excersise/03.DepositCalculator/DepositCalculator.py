deposit_amount = float(input())
deposit_period = int(input())
annual_interest_rate = float(input())

interest_accumulated = deposit_amount * (annual_interest_rate / 100)
monthly_interest = interest_accumulated / 12
total_amount = deposit_amount + deposit_period * monthly_interest

print(f'{total_amount:.2f}')
