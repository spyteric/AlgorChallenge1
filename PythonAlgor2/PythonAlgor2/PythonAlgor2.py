def rawInputTest():
    return raw_input(">>> M Input: ")


'''n  = rawInputTest()

OList = [True] * int(n)

 
OList[0]=OList[1]=False;


for i in range(2, int(n), 1):
    if(OList[i]):
        for i in range(i*i,int(n),i):
            OList[i] = False

returnList= []

for idx, val in enumerate(OList):
    if(val):
        returnList.append(idx)   


print(returnList)'''

'''for i in range(int(n)):
    OList.append(i)'''


from time import clock

def calPrime(n):
    primes = []
    n += 1
    mask = [0] * n
    max = int(n ** .5) + 1

    for i in xrange(3, n, 2):
        if not mask[i]:
            primes.append(i)

            if i < max:
                for j in xrange(i * i, n, i):
                    mask[j] = 1

    if n >= 2:
        primes.insert(0, 2)

    return primes
c = clock()
primes = calPrime(10000000)
print clock() - c
#print primes
print len(primes)



#for
#OriginalList=