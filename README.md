# SharesAPI
Just making an API to query shares values over a period of time which can be specified. Hopefully this will grow into something which will allow us to extract more meaningful info. But rome was not built in a day.!

- Part One
    - A list of known companies must be stored (not really stored just supported) which allows a user to query share prices.
    - A user may want to check the results over a period of time. Which they can specify.
    - The user may also want to indicate which intervals to use. Ex 1 day 4 hours etc.

- Part Two
    - The user would also like some basic statistics returned about the price fluctuations.

## Input/ Outputs
Section effectively details various requests and responses.

- Part One
    - Input (Request):
        - Company Name(NASDAQ)
        - Start Date
        - End Date
        - Time increment
    - Output (Response):
        - Comany Name
        - time and value collection.
    - Output (Response):
        - Bad values need to return a meaning full response