# List
inputs = [0] * 10
inputs[5] += 1
print(len(inputs))
inputs.sort(reverse=True)
print(inputs)
inputs = sorted(inputs, key=lambda i: -i + 1)
print(inputs)
inputs = [i * 2 for i in inputs]
print(inputs)
inputs.insert(3, 10) #index is 3, value is 10
print(inputs)
inputs.append(3)
inputs.extend([4, 5])
print(inputs)
inputs.remove(5) # 5 is value
inputs.pop()
inputs.pop(3) #3 is index
print(inputs)
for i, v in enumerate(inputs):
    print('{0} {1}'.format(i, v))
if 2 in inputs:
    print(True)
from random import shuffle
shuffle(inputs)

inputs = list(filter(lambda i: i > 0, inputs))
print(inputs)
print(sum(inputs))

#Map
inputs = {4:5}
inputs[1] = 3
inputs[1] += 1
print(len(inputs))
keys = [k for k in inputs.keys()]
values = [v for v in inputs.values()]
sums = [v+k for k, v in inputs.items()]
print(keys)
print(values)
print(sums)
inputs.pop(1)
print(inputs)
inputs[2] = 3
inputs = {k:k for k in range(10)}
print(inputs)

inputs = {k: v for k, v in inputs.items() if k > 5 and v < 7}
print(inputs)

#set
inputs = set()
inputs = {3, 2}
print(len(inputs))
outputs = [i for i in inputs]
print(outputs)
inputs.add(4)
inputs.add(4)
print(inputs)
inputs.difference_update({2, 1})
print(inputs)
inputs = inputs.union([3, 4, 5])
inputs = inputs.union({6})
print(inputs)
print(inputs.intersection({3, 5, 2, 1}))
inputs.remove(6)
print(inputs)
print({i: i + 1 for i in inputs if i > 4})
if 6 in inputs:
    print(True)
else:
    print(False)