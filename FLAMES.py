a = input("Enter the first name: ").lower()
b = input("Enter the second name: ").lower();
plus = ""

i = j = 0

while i<len(a):
    while j<len(b):
        if a[i] == b[j]:
            plus.join(a[i])
            a = a.replace(a[i], "", 1)
            b = b.replace(b[j], "", 1)
        j += 1
    j = 0
    i += 1

length = (len(a) + len(b))
rem = length%6

print()

print("Result: ", length)

print()

print("Using the FLAMES analysis...")

if rem == 1:
    print("You two should be friends")
elif rem == 2:
    print("You two should be lovers")
elif rem == 3:
    print("You two should be admirers")
elif rem == 4:
    print("You two should get married")
elif rem == 5:
    print("You two should be enemies")
elif rem == 0:
    print("You two should be secret admirers")

print()
    

    