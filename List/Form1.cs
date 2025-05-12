namespace odevList

{
    public partial class formScreen : Form
    {
        private LinkedList linkedList = new LinkedList();
        public formScreen()
        {
            InitializeComponent();
        }
        public class Node
        {
            public string Data;     // D���mde saklanacak veri
            public Node Next;    // Sonraki d���m�n referans�

            public Node(string data)
            {
                Data = data;
                Next = null;
            }
        }
        public class LinkedList
        {
            private Node head;  // Listenin Ba�taki d���m�

            public LinkedList()
            {
                head = null;
            }

            // Ba� tarafa d���m eklemek
            public void AddFirst(string data)
            {
                Node newNode = new Node(data);
                newNode.Next = head;
                head = newNode;
            }

            // Son tarafa d���m eklemek 
            public void AddLast(string data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }
            public void InsertAfter(string targetData, string newData)
            {
                Node current = head;

                // Hedef veriyi bulana kadar ilerle metotu
                while (current != null && current.Data != targetData)
                {
                    current = current.Next;
                }

                if (current != null)
                {
                    Node newNode = new Node(newData);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                }
                else
                {
                    MessageBox.Show($"Hedef de�er {targetData} bulunamad�.");
                }
            }
            // Girilen bilgiye g�re d���m silmek 
            public void Delete(string data)
            {
                if (head == null) return;

                if (head.Data == data)
                {
                    head = head.Next;
                    return;
                }

                Node current = head;
                while (current.Next != null && current.Next.Data != data)
                {
                    current = current.Next;
                }

                if (current.Next != null)
                {
                    current.Next = current.Next.Next;
                }
                else
                {
                    MessageBox.Show($"Hedef de�er bulunamad�.");
                }
            }

            // Bu kod Listeyi Yazd�rmak i�indir
            public string PrintList()
            {
                string list = "";
                Node current = head;
                while (current != null)
                {
                    list += (current.Data + " -> ");
                    current = current.Next;
                }
                list += "null";
                return list;
            }
        }
        private void addHead_Click(object sender, EventArgs e)
        {
            linkedList.AddFirst(addFirstBox.Text);
            textBox.Text = linkedList.PrintList();
        }

        private void addLast_Click(object sender, EventArgs e)
        {
            linkedList.AddLast(addLastBox.Text);
            textBox.Text = linkedList.PrintList();
        }

        private void addMiddle_Click(object sender, EventArgs e)
        {

            linkedList.InsertAfter(targetBox.Text, addMiddleBox.Text);
            textBox.Text = linkedList.PrintList();
        }

        private void deleteNode_Click(object sender, EventArgs e)
        {
            linkedList.Delete(deleteBox.Text);
            textBox.Text = linkedList.PrintList();
        }

        private void formScreen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}