pages_per_book = int(input())
pages_per_hour = int(input())
days_for_reading = int(input())

total_hours = pages_per_book / pages_per_hour
hours_per_day = total_hours / days_for_reading

print(int(hours_per_day))
