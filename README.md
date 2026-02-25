<p align="center">
  <img src="https://img.shields.io/badge/Unity-2022+-black?style=for-the-badge&logo=unity&logoColor=white" alt="Unity">
  <img src="https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white" alt="C#">
</p>

<h1 align="center">🎮 Gold Collector Ball Game</h1>

<p align="center">
  Unity ve C# kullanılarak geliştirilmiş, refleks ve dikkat odaklı basit ama eğlenceli bir arcade oyunudur. Oyuncu, bir topu kontrol ederek gelen altınları toplar, bombalardan kaçınır ve mümkün olduğunca yüksek skor elde etmeye çalışır.
</p>

<p align="center">
  <i>Bu proje; Unity oyun mekaniği, fizik tabanlı hareket ve oyun yönetimi sistemleri üzerindeki yetkinliği göstermek amacıyla geliştirilmiştir.</i>
</p>

---

## 🛠️ Kullanılan Teknolojiler
Oyunun geliştirilme sürecinde kullanılan temel araçlar:

![Unity](https://img.shields.io/badge/unity-%23000000.svg?style=for-the-badge&logo=unity&logoColor=white) 
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![UI](https://img.shields.io/badge/Unity-UI%20%26%20TMP-blue?style=for-the-badge)



---

## 🕹️ Oynanış
* ⌨️ **Kontrol:** Oyuncu klavye yön tuşları ile topu kontrol eder.
* 🪙 **Hedef:** Altınlar rastgele konumlardan gelir, topladıkça skor artar.
* 💣 **Engel:** Bombalara çarpıldığında can azalır.
* ⚰️ **Bitiş:** Can bittiğinde oyun sona erer.

---

## ✨ Özellikler
* 🎯 **Fizik Tabanlı Top Kontrolü:** Rigidbody kullanılarak gerçekçi hareket sistemi.
* 🪙 **Altın Toplama Sistemi:** Trigger ile skor artırma ve ses efekti.
* 💣 **Bomba & Hasar Mekaniği:** Can sistemi ve oyun sonu paneli.
* ❤️ **Can (Health) Yönetimi:** UI üzerinden anlık can takibi.
* 🔊 **Ses Efektleri:** Altın toplama ve bomba çarpma sesleri.
* ⏱️ **Dinamik Zorluk:** Coroutine ile rastgele nesne üretim (spawn) sistemi.

---

## 📸 Ekran Görüntüsü
Oyun tek ekrandan oluşmaktadır.

<p align="center">
  <img src="Assets/gameplay.png" width="700" alt="Gameplay Screen">
</p>

---

## 📁 Proje Yapısı
```text
Assets/
├── Scripts/
│   ├── BallControl.cs        # Top hareketi
│   ├── Coin.cs               # Altın toplama
│   ├── CoinSpawner.cs        # Altın üretimi
│   ├── Bomb.cs               # Bomba davranışı
│   ├── HealthManager.cs      # Can sistemi
│   ├── GameManager.cs        # Skor yönetimi
│   └── AudioManager.cs       # Ses yönetimi
