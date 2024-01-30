import { expect } from 'chai';
import { sum } from './SumofNumbers.js'

describe('Sum Numbers', () => {
    it ('Should return 0 if empty array is given', () => {
        // Arrange
        const inputArray = [];
        // Act
        const result = sum(inputArray);
        //Assert
        expect(result).to.equals(0);
    });
    it ('Should return number N in only one number N is given in the array', () => {
        // Arrange
        const inputArray = [45];
        // Act
        const result = sum(inputArray);
        // Assert
        expect(result).to.equals(45);
    })
    it ('Should return the sum of the two inpunts in the array (45 + 55 = 100)', () => {
        // Arrange
        const inputArray = [45, 55];
        // Act
        const result = sum(inputArray);
        // Assert
        expect(result).to.equals(100);
    })
    it ('Should subtract two numbers if one of the two inputs is a negative, and not take the modules of the numbers', () => {
        // Arrange
        const inputArray = [45, -55];
        // Act
        const result = sum(inputArray);
        // Assert
        expect(result).to.equals(-10);
        })
    it ('Should be able to add multiple numbers', () => {
            // Arrange
        const inputArray = [45, 55, 10, 90, 200, -100];
        // Act
        const result = sum(inputArray);
        // Assert
        expect(result).to.equals(300);
    })
});