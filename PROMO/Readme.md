# PROMO
aplikasi ini berfungsi untuk seseorang dalam memesan makan dan minuman serta mendapatkan promo.

## Scope & Functionalities
- user dapat memesan makanan
- user dapat memesan minuman
- user bisa mendapatkan potongan harga

## How Does it Works?
diawali dari Method `MainWindow` pada class MainWindow.xaml.cs, cara mendeklasarikan sebagai berikut

```csharp
 {
            InitializeComponent();

            payment = new Payment(this);
            payment.setBalance(500000);
            payment.setDeliveryFee(15000);
            payment.setPromo(5000);

            KeranjangBelanja keranjangBelanja = new KeranjangBelanja(payment, this);

            controller = new MainWindowController(keranjangBelanja);

            listBoxPesanan.ItemsSource = controller.getSelectedItems();

            initializeView();

        }
```

