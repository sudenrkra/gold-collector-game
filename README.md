# 🎮 Gold Collector Ball Game

 Unity ve C# kullanılarak geliştirilmiş, refleks ve dikkat odaklı basit ama eğlenceli bir arcade oyunudur.  
Oyuncu, bir topu kontrol ederek gelen altınları toplar, bombalardan kaçınır ve mümkün olduğunca yüksek skor elde etmeye çalışır.

Bu proje, **Unity oyun mekaniği**, **fizik tabanlı hareket**, **collision & trigger kullanımı** ve **oyun yönetimi sistemleri** konularındaki yetkinliği göstermek amacıyla geliştirilmiştir.

---

## 🕹️ Oynanış

- Oyuncu klavye yön tuşları ile topu kontrol eder
- Altınlar rastgele konumlardan oyuncuya doğru gelir
- Altınları topladıkça skor artar
- Bombalara çarpıldığında can azalır
- Can bittiğinde oyun sona erer

---

## ✨ Özellikler

- 🎯 **Fizik Tabanlı Top Kontrolü**  
  Rigidbody kullanılarak gerçekçi hareket sistemi

- 🪙 **Altın Toplama Sistemi**  
  Trigger ile skor artırma ve ses efekti

- 💣 **Bomba & Hasar Mekaniği**  
  Can sistemi ve oyun sonu paneli

- ❤️ **Can (Health) Yönetimi**  
  UI üzerinden anlık can takibi

- 🔊 **Ses Efektleri**  
  Altın toplama ve bomba çarpma sesleri

- ⏱️ **Rastgele Nesne Spawn Sistemi**  
  Coroutine ile dinamik zorluk

---

## 🛠️ Kullanılan Teknolojiler

- **Game Engine:** Unity  
- **Programlama Dili:** C#  
- **Physics:** Rigidbody, Collider, Trigger  
- **UI:** Unity UI & TextMeshPro  
- **Architecture:** Singleton Pattern (GameManager, AudioManager)

---

📸 Ekran Görüntüsü

Oyun tek ekrandan oluşmaktadır.

![Gameplay](assets/gameplay.png)

## 📁 Proje Yapısı

---

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
