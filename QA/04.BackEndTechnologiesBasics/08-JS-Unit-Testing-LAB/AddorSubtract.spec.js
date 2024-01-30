import { createCalculator } from './AddorSubtract.js'
import { expect } from 'chai'

describe ('Add function tests', () => {
    it ('Should return the beggining valie 0 if no opeartions are made', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        const result = calculator.get();
        //Assert
        expect(result).to.equals(0);
    })
    it ('Should be able to return the input value if we are only adding that one value', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        calculator.add(10)
        const result = calculator.get();
        //Assert
        expect(result).to.equals(10);
    })
    it ('Should be able to handle negative number adding as a subtraction', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        calculator.add(40)  //0 + 40 = 40
        calculator.add(-10) //40 + (-10) = 30
        const result = calculator.get();
        //Assert
        expect(result).to.equals(30);
    })
    it ('Should be able to return negative results from the add function alone', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        calculator.add(-10)
        calculator.add(1)
        const result = calculator.get();
        //Assert
        expect(result).to.equals(-9);
    })
    it ('Should be able to use numbers as strings', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        calculator.add("-40")
        calculator.add('60')
        calculator.add(-20)
        const result = calculator.get();
        //Assert
        expect(result).to.equals(0);
    })
    it ('Shoud be able to add fractional numbers', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        calculator.add(5.555)
        const result = calculator.get();
        //Assert
        expect(result).to.equals(5.555);
    })
})
describe ('Subtract function tests', () => {
    it ('Should return the beggining valie 0 if no opeartions are made', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        const result = calculator.get();
        //Assert
        expect(result).to.equals(0);
    })
    it ('Should be able to return 0 - (input value) if we are only substracting that one value', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        calculator.subtract(10)
        const result = calculator.get();
        //Assert
        expect(result).to.equals(-10);
    })
    it ('Should be able to handle negative number subtraction as an addition', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        calculator.subtract(40)  //0 - 40 = -40
        calculator.subtract(-10) //40 - (-10) = -30
        const result = calculator.get();
        //Assert
        expect(result).to.equals(-30);
    })
    it ('Should be able to return positive results from the substract function alone', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        calculator.subtract(-10)
        calculator.subtract(1)
        const result = calculator.get();
        //Assert
        expect(result).to.equals(9);
    })
    it ('Should be able to use numbers as strings', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        calculator.subtract("-40")  //=40
        calculator.subtract('60')   //=-20
        calculator.subtract(-20)    //=0
        const result = calculator.get();
        //Assert
        expect(result).to.equals(0);
    })
    it ('Shoud be able to subtract fractional numbers', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        calculator.subtract(5.555)
        const result = calculator.get();
        //Assert
        expect(result).to.equals(-5.555);
    })
})
describe ('Both functions at once tested', () => {
        it ('Should be able to use both add and subtract with nums and strings, positives and negatives, and fractions, all in a mix', () => {
        //Arrange
        const calculator = createCalculator();
        //Act
        calculator.subtract(5.555)      //0 - 5.555 = -5.555
        calculator.add(-20)             //-5.555 + (-20) = -25.555
        calculator.subtract(-15.055)    //-25.555 - (-15.055) = -10.5
        calculator.add('30.50')         //-10.5 + 30.5 = 20
        const result = calculator.get();
        //Assert
        expect(result).to.equals(20);
        })
})