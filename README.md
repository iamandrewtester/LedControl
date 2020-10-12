# LedControl
Control LEDs on a wifI connected Arduino with UDP packets.

The Arduino code will accept simple 2-byte commands like "B100" to set blue to value 100. The second byte is assigned the hex value of 100 in the code.
The command S0 will reset all values.

Set the ip string value to the ip of your Arduino shield.
Power on the Arduino before running this code, or the connection will fail.
