
def f(m):
    m and m.pop(0) + f([list(x) for x in zip(*m)][::-1])


if __name__ == "__main__":
    v = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]]
    print(v.pop(0))
    v = [list(x) for x in zip(*v)][::-1]
    v.pop(0)
    print(v)
    v = [list(x) for x in zip(*v)][::-1]
    print(v)
    v.pop(0)
    v = [list(x) for x in zip(*v)][::-1]
    print(v)
    v = [list(x) for x in zip(*v)][::-1]
    print(v)
    v = [list(x) for x in zip(*v)][::-1]
    print(v)
