function calculateOrderPrice(product, quantity) {
    let pricePerPiece;

    switch (product) {
        case 'coffee':
            pricePerPiece = 1.50;
            break;
        case 'water':
            pricePerPiece = 1.00;
            break;
        case 'coke':
            pricePerPiece = 1.40;
            break;
        case 'snacks':
            pricePerPiece = 2.00;
            break;
        default:
            console.log('Invalid product.');
            return;
    }

    const totalPrice = (pricePerPiece * quantity).toFixed(2);
    console.log(totalPrice);
}

calculateOrderPrice("water", 5);
calculateOrderPrice("coffee", 2);
