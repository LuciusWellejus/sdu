# Opgave 55:
# International currency exchange rates change frequently.
# Investigate current exchange rates, and update the currency converter script from Section 1.8 accordingly

# A converter for international currency exchange.

USD_to_GBP = 0.76   # Current rate, US dollars to British Pounds. | Before 0.76
USD_to_EUR = 0.89   # Current rate, US dollars to Euros.          | Before 0.86
USD_to_JPY = 157.63 # Current rate, US dollars to Japanese Yen.   | Before 114.08
USD_to_INR = 96.10  # Current rate, US dollars to Indian Rupees.  | Before 63.64
USD_to_SEK = 10.04  # Current rate, US dollars to Swedish Krona.


GBP_sign = '\u00A3' # Unicode values for non-ASCII currency
EUR_sign = '\u20AC' # symbols.
JPY_sign = '\u00A5'
INR_sign = '\u20B9'
SEK_sign = '\u006B\u0072'  # Svarer til 'kr'

dollars = 1000 # The number of dollars to convert

pounds = dollars * USD_to_GBP # Conversion calculations
euros = dollars * USD_to_EUR

yen = dollars * USD_to_JPY
rupees = dollars * USD_to_INR

print('Today, $' + str(dollars)) # Printing the results
print('converts to ' + GBP_sign + str(pounds))
print('converts to ' + EUR_sign + str(euros))
print('converts to ' + JPY_sign + str(yen))
print('converts to ' + INR_sign + str(rupees))

# Output

# When executed, this script outputs the following:
# Today, $1000
# converts to £760.0
# converts to €860.0
# converts to ¥114080.0
# converts to 63640.0