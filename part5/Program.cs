public class MyDictionary<TKey, TValue>
{
    TKey[]? key;
    TValue[]? value;
    int count;
    public int Count => count;

    public MyDictionary()
    {
        count = 0;
        key = new TKey[] { };
        value = new TValue[] { };
    }
    public MyDictionary(int size)
    {
        count = size;
        key = new TKey[size];
        value = new TValue[size];
    }
    public MyDictionary(MyDictionary<TKey, TValue> list)
    {
        count = list.Count;
        key = list.key;
        value = list.value;
    }

    public TKey? Key(int index)
    {
        return key[index];
    }

    public TValue this[TKey key]
    {
        get => this[key];
        set => this[key] = value;
    }

    public void Add(TKey key, TValue value)
    {
        for (int i = 0; i < this.key.Length; i++)
        {
            if (Equals(key, this.key[i])) { throw new ArgumentException("This key is already use"); }
        }
        MyDictionary<TKey, TValue> temp = new MyDictionary<TKey, TValue>(count + 1);
        for (int i = 0; i < count; i++)
        {
            temp.key[i] = this.key[i];
            temp.value[i] = this.value[i];
        }
        temp.key[count] = key;
        temp.value[count] = value;
        this.key = temp.key;
        this.value = temp.value;
        count++;
    }

    public IEnumerator<TKey> GetEnumerator()
    {
        for (int i = 0; i < count; i++)
        {
            yield return key[i];
        }
    }
}