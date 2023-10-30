#one.py
def func():
	print("FUNC() IN ONE.PY")

print("Top level in one.py")

if __name__ == '__main__':
	print("ONE.PY is being run directly!")
else:
	print("ONE.PY has been imported")