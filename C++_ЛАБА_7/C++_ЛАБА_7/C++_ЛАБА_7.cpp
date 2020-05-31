#include <iostream>
#include <queue>        // подключаем заголовочный файл очереди
#include <string>       // заголовочный файл для работы со строками типа string
#include <stack>
using namespace std;
template<class T>
class Stack {
    struct node {
        T d;
        node* next;
        node(void) : next(NULL) {}
    };
private:
    node* ptr;
public:
    Stack(void) : ptr(NULL) {}
    ~Stack() {
        this->clear();
    }

    // добавление элемента по LIFO (последним зашёл, первым вышел)
    void  push(T d) {
        node* n = new node();
        n->next = ptr;
        n->d = d;
        ptr = n;
    }
    T& top(void) { return ptr->d; }

    // вытолкнуть элемент из верхушки стека
    void pop(void) {
        node* tmp = ptr;
        ptr = ptr->next;
        delete tmp;
        tmp = NULL;
    }
    bool empty(void) const { return (!ptr); }

    // удалить весь стек
    void clear(void) {
        node* tmp;
        while (ptr != NULL) {
            tmp = ptr;
            ptr = ptr->next;
            delete tmp;
            tmp = NULL;
        }
    }
};
int main(void)
{
    setlocale(LC_ALL, "Russian");
  
    
        cout << "Базовый уровень\n14) Существует непустая очередь.  Извлечь  из очереди N (N > 0) начальных  элементов  и вывести  их значения.\nЕсли очередь содержит менее N елементов, то извлечь все ее елементы.";
        queue<string> character;     // создаем пустую очередь типа string
        character.push("Роулинг:");
        character.push("Гарри");
        character.push("Джинни");
        character.push("Рональд");
        character.push("Гермиона");
        character.push("Фред/Джордж");
        character.push("Дред/Фордж");
        character.push("Персиваль");
        character.push("Невилл");
        character.push("Полумна");
        character.push("Альбус");
        character.push("Северус");
        character.push("Минерва");
        int N, n;
        cout << "Количество елементов очереди:  " << character.size();
        cout << "\nВведите количество извлекаемых елементов:  ";
        cin >> N;
        if (N <= 0)
        {
            while (N <= 0)
            {
                cout << "Нельзя вводить числа меньше или равные 0 :(\nВведите N ещё раз: ";
                cin >> N;
            }
        }
        if (N > character.size())
        {
            int i = 1;
            n = character.size();
            while (i <= n)
            {
                cout << "\nИзвлеченный элемент(" << i << "):   " << character.front();
                character.pop(); // удаляем один элемент в очереди
                i++;
            }
            cout << endl;
        }
        else
        {
            n = character.size() - N;
            for (int i = 0; i < N; i++)
            {
                cout << "\nИзвлеченный элемент (" << i + 1 << "):   " << character.front();
                character.pop(); // удаляем один элемент в очереди
            }
            cout << "\nКоличество оставшихся элементов в очереди: " << n << endl;
        }  
        ////////////////////////////////////////////////////


        cout << "\nСредний Уровень\n14) Создать стек строковых значений, для реализации используя односвяз-ные списки. Реализовать операции добавления (push) и удаления (pop) элемента из стека. Добавьте в стек строки «abc »,  «de »,  «f »,  «g»  ,  «hi », «jk » и распечатайте содержимое стека. Удалите один элемент из стека, и распечатайте  содержимое  стека  еще  раз.";
        cout << endl;
        int k = 0;
        Stack<string> st;
    Stack<string> sta;
    // заполняем стек
    string a[7] = { "abc","de","f","g","hi","jk" };
    for (int i = 0; i < 6; i++) 
    {
        st.push(a[i]);
        if (a[i].length() == 1) { k++; }
    } 
    // выводим все элементы стека в консоль
    while (!st.empty()) {
        cout << st.top() << " ";
        st.pop();
    }cout << "\nВ стеке " << k << " одно-символьных строк\n" << endl;
    cout << endl;
    
    k = 0;
    for (int i = 0; i < 5; i++)
    {
        sta.push(a[i]);
        if (a[i].length() == 1) { k++; }
    }  
    while (!sta.empty()) {
        cout << sta.top() << " ";
        sta.pop();
    }cout << "\nВ стеке " << k << " одно-символьных строк\n" << endl;
    cin.get();
    return 0;
}