Feature: PriceCalculator

A short summary of the feature
Price of -1 is to indicate an exception

@CleaningCalculation
Scenario Outline: Calculate Price for Cleaning
	Given I have entered an <area>
	And I have also decided if IsDeluxe <IsDeluxe>
	And I have also decided if IsDoubleWash <IsDoubleWash>
	And I have also decided if IsImpreg <IsImpreg>
	When I press button Calculate price
	Then The result should be <Price>

	Examples:
	| area | IsDeluxe | IsDoubleWash | IsImpreg | Price |
	| -1   | 'false'  | 'false'      | 'false'  | -1    | 
	| 0    | 'false'  | 'false'      | 'false'  | 500   |
	| 1    | 'false'  | 'false'      | 'false'  | 520   |
	| 99   | 'false'  | 'false'      | 'false'  | 2480  |
	| 100  | 'false'  | 'false'      | 'false'  | 2500  |
	| 101  | 'false'  | 'false'      | 'false'  | 2515  |
	| 199  | 'false'  | 'false'      | 'false'  | 3985  |
	| 200  | 'false'  | 'false'      | 'false'  | 4000  |
	| 201  | 'false'  | 'false'      | 'false'  | 4010  |
	| 499  | 'false'  | 'false'      | 'false'  | 6990  |
	| 500  | 'false'  | 'false'      | 'false'  | 7000  |
	| 501  | 'false'  | 'false'      | 'false'  | -1    |
	| 200  | 'true'   | 'false'      | 'false'  | 6400  |
	| 200  | 'false'  | 'true'       | 'true'   | 6400  |
	| 200  | 'false'  | 'true'       | 'false'  | 6000  |
	| 200  | 'false'  | 'false'      | 'true'   | 4800  |
	