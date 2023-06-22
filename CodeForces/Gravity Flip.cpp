# include <iostream>
# include <algorithm>

using namespace std;

int main()
{
    int cols;
    cin >> cols;
    int v[cols];
    int a;
    for (int i; i < cols; i++)
    {
        cin >> a;
        v[i] = a;
    }
    sort(v, v + cols);
    for (int a : v)
        cout << a << " ";
}
