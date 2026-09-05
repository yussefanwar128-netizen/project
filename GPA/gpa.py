print("\t GPA (python)")
math =float(input("math : "))
if math>100 or math<0:
    print("Enter the correct number")
    exit()
english =float(input("english : "))
if english>100 or english<0:
    print("Enter the correct number")
    exit()
physics =float(input("physics : "))
if physics>100 or physics<0:
    print("Enter the correct number")
    exit()
chemistry =float(input("chemistry : "))
if chemistry>100 or chemistry<0:
    print("Enter the correct number")
    exit()
biology =float(input("biology : "))
if biology>100 or biology<0:
    print("Enter the correct number")
    exit()
total = math+english+physics+chemistry+biology
print(total)
average = total/5
print(average)

if average>=90 and average<=100:
    print("A")
elif average>=80 and average<90:
    print("B")
elif average>=70 and average<80:
    print("C")
elif average>=60 and average<70:
    print("D")
elif average>=50 and average<60:
    print("D-")
else:
    print("F")