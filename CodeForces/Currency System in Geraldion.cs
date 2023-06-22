# include <iostream>

using namespace std;

int main()
{
    int n;
    int x;
    cin >> n;
    bool Is_unfortunate = false;
    for (int i = 0; i < n; i++)
    {
        cin >> x;
        if (x == 1)
            Is_unfortunate = true;
    }
    if (Is_unfortunate)
        cout << -1;
    else
        cout << 1;
    return 0;
}
