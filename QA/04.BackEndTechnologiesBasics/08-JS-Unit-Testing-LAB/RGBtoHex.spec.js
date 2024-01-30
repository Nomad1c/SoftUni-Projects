import { rgbToHexColor } from './RGBtoHex.js'
import {expect} from 'chai'

describe ('rgbToHexColor', () => {
    it ('Should return coresponding hex if a proper color is given', () => {
        const red = 200
        const green = 100
        const blue = 50
        //Act
        const result = rgbToHexColor(red, green, blue)
        //assert
        expect(result).to.equals('#C86432')
    })
    it ('Should return undefined if a color is missing', () => {
        const red = 200
        const green = 200
        //Act
        const result = rgbToHexColor(red, green)
        //assert
        expect(result).to.equals(undefined)
    })
    it('Should return coresponding color to the first 3 inputs if there are more than 3 colors as input', () => {
        const red = 200
        const green = 200
        const blue = 200
        const other = 200
        //Act
        const result = rgbToHexColor(red, green, blue, other)
        //assert
        expect(result).to.equals('#C8C8C8')
    })
    it ('Should return undefined if a color num is out of range', () => {
        //Arage
        const red1 = 200
        const red2 = 200
        const green1 = 200
        const green2 = 200
        const blue1 = 500   //Over
        const blue2 = -1    //Under
        //Act
        const result1 = rgbToHexColor(red1, green1, blue1)
        const result2 = rgbToHexColor(red2, green2, blue2)
        //assert
        expect(result1).to.equals(undefined)
        expect(result2).to.equals(undefined)
    })
    it ('Should return undefined if a color number is a string', () => {
        const red = 200
        const green = '200'
        const blue = 200
        //Act
        const result = rgbToHexColor(red, green, blue)
        //assert
        expect(result).to.equals(undefined)
    })
})
describe ('rgbToHexColorEdgeCases', () => {
    it ('Should return #FFFFFF if input is the max input alowed (255, 255, 255)', () => {
        //Arage
        const red = 255
        const green = 255
        const blue = 255
        //Act
        const result = rgbToHexColor(red, green, blue)
        //assert
        expect(result).to.equals("#FFFFFF")
    })
    it ('Should return #000000 if input is the max input alowed (0, 0, 0)', () => {
        //Arage
        const red = 0
        const green = 0
        const blue = 0
        //Act
        const result = rgbToHexColor(red, green, blue)
        //assert
        expect(result).to.equals("#000000")
    })
})