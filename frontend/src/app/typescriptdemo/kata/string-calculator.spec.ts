import { NoNegativesAllowedExecption } from './NoNegativesAllowedException';
import { StringCalculator } from './string-calculator';

describe('String Calculator', () => {
  describe('1.0 Empty String Returns Zero', () => {
    it('First Example', () => {
      const calculator = new StringCalculator();

      let result = calculator.add('');

      expect(result).toEqual(0);
    });
  });

  describe('1.1 Single Number', () => {
    let calculator: StringCalculator;

    beforeEach(() => {
      calculator = new StringCalculator();
    });

    it('First', () => {
      const result = calculator.add('1');
      expect(result).toEqual(1);
    });

    it('Second', () => {
      const result = calculator.add('2');
      expect(result).toEqual(2);
    });

    it('Third', () => {
      const result = calculator.add('3');
      expect(result).toEqual(3);
    });
  });

  describe('1.2 Two Numbers', () => {
    let calculator: StringCalculator;

    beforeEach(() => {
      calculator = new StringCalculator();
    });

    it('First', () => {
      const result = calculator.add('1,2');
      expect(result).toEqual(3);
    });

    it('Second', () => {
      const result = calculator.add('3,4');
      expect(result).toEqual(7);
    });

    it('Third', () => {
      const result = calculator.add('10,20');
      expect(result).toEqual(30);
    });
  });

  describe('2.0 Multiple Numbers', () => {
    let calculator: StringCalculator;

    beforeEach(() => {
      calculator = new StringCalculator();
    });

    it('First', () => {
      const result = calculator.add('1,2,3,4,5,6,7,8,9');
      expect(result).toEqual(45);
    });
  });

  describe('3.0 New Line As Delim', () => {
    let calculator: StringCalculator;

    beforeEach(() => {
      calculator = new StringCalculator();
    });

    it('First', () => {
      const result = calculator.add('1\n2');
      expect(result).toEqual(3);
    });

    it('Second', () => {
      const result = calculator.add('1\n2,3');
      expect(result).toEqual(6);
    });
  });

  describe('4.0 Different Delimiters', () => {
    let calculator: StringCalculator;

    beforeEach(() => {
      calculator = new StringCalculator();
    });

    it('First', () => {
      const result = calculator.add('//;\n1;2');
      expect(result).toEqual(3);
    });

    it('Use the comma and new line + new delim', () => {
      const result = calculator.add('//;\n1;2;3,4\n5');
      expect(result).toEqual(15);
    });
  });

  describe('5.0 No Negatives Allowed Exception', () => {
    let calculator: StringCalculator;

    beforeEach(() => {
      calculator = new StringCalculator();
    });

    it('First', () => {
      const result = calculator.add('1,-2');

      expect(() => {
        calculator.add('1,-2');
      }).toThrow(new NoNegativesAllowedExecption('No Negatives Allowed -2'));
    });
  });
});
