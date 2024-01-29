import { expect } from 'chai'
import { isSymmetric } from './02.CheckforSymmetry.js'

describe ('isSymmetric', () => {
    it ('Should return true if no input in the array, because nothing is symmetric', () => {
        //Arrange
        const inputArray = []
        //Act
        const result = isSymmetric(inputArray)
        //Assert
        expect(result).to.equals(true)
    })
    it ('Should return false if the input array numbers are in diferent types', () => {
        //Arrange
        const inputArray = [1, '2', 3, 2, 1]
        //Act
        const result = isSymmetric(inputArray)
        //Assert
        expect(result).to.equals(false)
    })
    it ('Should return true if the input array is made of symmetric numbers', () => {
        //Arrange
        const inputArray = [78, 7, 5, 4, 5, 7, 78]
        //Act
        const result = isSymmetric(inputArray)
        //Assert
        expect(result).to.equals(true)
    })
    it ('Should return false if input array is nonsymmetric', () => {
        //Arrange
        const inputArray = [2, 3, -6]
        //Act
        const result = isSymmetric(inputArray)
        //Assert
        expect(result).to.equals(false)
    })
    it ('Should return true if input array numbers are even in amount', () => {
        //Arrange
        const inputArray = [-2, 2, -45, -45, 2, -2]
        //Act
        const result = isSymmetric(inputArray)
        //Assert
        expect(result).to.equals(true)
    })
    it ('Should return false if input is not an array', () => {
        //Arrange
        const inputString = "-2, 2, -45, -45, 2, -2"
        //Act
        const result = isSymmetric(inputString)
        //Assert
        expect(result).to.equals(false)
    })
})