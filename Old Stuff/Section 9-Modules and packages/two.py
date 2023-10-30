#two.py
import one

print("Top level in two.py")

one.func()

def func2():
	print("Hi Am from two.py")

if __name__ == '__main__':
	print("TWO.py is being run directly");
else:
	print("Two.py has been imported")