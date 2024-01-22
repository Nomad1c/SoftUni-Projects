chicken_menus = int(input())
fish_menus = int(input())
vegetarian_menus = int(input())

chicken_menu_price = 10.35
fish_menu_price = 12.40
vegetarian_menu_price = 8.15

total_menus_price = (chicken_menus * chicken_menu_price) + (fish_menus * fish_menu_price) + (vegetarian_menus * vegetarian_menu_price)

dessert_price = 0.20 * total_menus_price
delivery_price = 2.50

total_order_price = total_menus_price + dessert_price + delivery_price

print(f'{total_order_price:.2f}')
