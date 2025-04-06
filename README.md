# Projekt miksera audio na podstawie Rane SIXTY-TWO z wykorzystaniem biblioteki NAudio

Ze względu na wykorzystanie biblioteki NAudio program jest przeznaczony tylko na komputery z systemem operacyjnym Windows.

## Instrukcja obsługi:  
1. Program należy uruchomić w dowolnym środowisku obsługującym platformę .NET (.NET 8.0).  
2. Po uruchomieniu zostaną wyświetlone dwa okna - Mixer oraz Player.  
###  Odtwarzacz:

1. **Dodanie plików do odtwarzacza** (obsługiwane formaty .mp3, .wav, .aiff, .wma):  
   a) Naciśnięcie przycisku *Open* pozwoli na wybór pliku audio z dysku. Utwór zostanie automatycznie załadowany na wybrany kanał (nie ma potrzeby wykonywania kroku 2).  
   b) Utwory można również przeciągać i upuszczać na biały prostokąt okna odtwarzacza, co umożliwia tworzenie playlisty z wielu plików naraz.  
2. **Ładowanie utworu na wybrany kanał:**  
   a) Jeśli playlista jest aktywna (posiada „focus”), można zaznaczyć utwór, poruszając się po niej za pomocą strzałek „w górę” i „w dół”. Możliwe jest również zaznaczenie utworu kursorem myszy.  
   b) Po wybraniu utworu (podświetlony na niebiesko) należy nacisnąć jednocześnie klawisz „Shift” oraz strzałkę „w lewo” (załadowanie utworu na lewy kanał) lub „w prawo” (załadowanie na prawy kanał).  
3. **Sterowanie odtwarzaniem** jest realizowane przez przyciski:
- *Play* - odtwarza utwór kiedy jest on zatrzymany oraz pauzuje go kiedy jest odtwarzany,
- *Pause* - pauzuje utwór, 
- *Stop* - zatrzymuje utwór; ponowne jego odtworzenie rozpoczyna się od początku.  
Dodatkowo, jeśli program ma „focus” na playliście, odtwarzanie/pauzowanie można uzyskać poprzez naciśnięcie spacji i Entera – odpowiednio dla lewego i prawego kanału.  
4. **Załadowanie kolejnego utworu na dany kanał**
  Przed załadowaniem nowego utworu należy zatrzymać aktualnie odtwarzany utwór przyciskiem „Stop” lub „Pause”, a następnie załadować nowy utwór zgodnie z krokiem 2 lub 1.

    
### Mikser:  
Mikser umożliwia manipulowaniem dźwiękiem odtwarzanego utworu po przez zaimplementowane sekcje:
1. **Sekcja CUES** - pierwsze naciśnięcie pozwala na zapamiętanie konkretnego momentu odtwarzanego utworu (CuePoint), natomiast kolejne powodują powrót do zapamiętanego momentu.  
![obraz](https://github.com/user-attachments/assets/ca89c2de-b251-40c0-917a-43968ef249bb)
  
2. **Sekcja EQ** - sekcja składa się z kilku elementów:  
   (1). **Panorama** - pozwala ustawić balans dźwięku między lewym i prawym kanałem wyjściowym,   
   (2). **High-/LowPassFilter** - pozwala na sterowanie filtrem dolnoprzepustowym (przekręcenie w lewą stronę) oraz górnoprzepustowym (przekręcenie w prawą stronę),  
   (3). **CheckBox** włączający i wyłączający efekty na danym kanale (TODO),  
   (4). **Wskaźnik natężenia dźwięku** na danym kanale,  
   (5). **Gain** - steruje poziomem natężenia dźwięku kanału,  
   (6). **Equalizer** - 3 potencjometry pozwalające na sterowanie tonami wysokimi, średnimi i niskimi (patrząc od góry)  
![obraz](https://github.com/user-attachments/assets/e1510be7-0098-42ab-87a9-b7d3de159746)

3. **Sekcja EFFECTS** - (TODO) - akutualnie w budowie, nie działa do końca poprawnie, jednak jeśli najpierw włączysz efekt Echo, zaznaczysz checkBox "ON", zwiększysz gain efektu (wszystko jak poniżej) i dopiero wtedy załadujesz utwór na kanał to zadziała.
Najłatwiej usłyszeć działanie efektu przez wyciszenie utworu pionowym suwakiem z sekcji Fader.
Dodatkowo sekcja umożliwia sprawdzenie tempa utworu przez wybicie jego rytmu na przycisku "TAP". W przyszłości posłuży to do sterowania wartością "delay" w efekcie Echo  
 ![obraz](https://github.com/user-attachments/assets/b391a50d-6c7e-45a6-8a85-0af3ff2e2e6a)

4. **Sekcja LOOP** - pozwala na zapętlenie danego fragmentu utworu.
  - *In* – ustawienie początku pętli,
  - *Out* – ustawienie końca pętli,
  - *Exit* – wyjście z pętli.  
![obraz](https://github.com/user-attachments/assets/3fe82e56-a389-481f-b4eb-66dd28b69d2f)  

5. **Sekcja FADER** - 3 suwaki kontrolujące poziom natężenia dźwięku.  
- 2 pionowe odpowiadają za natężenie poszczególnych kanałów,
- jeden poziomy (Crossfader) odpowiada za balans między nimi (nie mylić z panoramą).
Działanie crossfadera dobrze obrazuje poniższy wykres, gdzie kolorowe kreski to natężenie dźwięku na poszczególnych kanałach. Przesunięcie suwaka na jedną ze stron spowoduje wyciszenie kanału po przeciwnej stronie.  
![obraz](https://github.com/user-attachments/assets/106eba0e-94bd-4e8b-80b3-84805f891707)
![obraz](https://github.com/user-attachments/assets/dbf21b86-a571-474e-ba72-34dac8d00558)

7. **Sekcja Mic** - mikser umożliwia rónież obsługę mikrofonu. Ze względu na brak implementacji wykrywania i wyciszania pętli mikrofon najlepiej działa przy odtwarzniu dźwięku przez słuchawki.  
- Przycisk "ON" (1) włącza mikrofon,
- Przycisk "OV" (2) (od OVER) sprawa, że grające kanały są odtwarzane na poziomie 20% zostawiając więcej miejsca na dźwięk mikrofonu.  
Dodatkowo sygnał mikrofonu może być modyfikowanu przez sterowanie jego natężeniem (3), Equalizer wzmacniający/osłabiajacy tony wysokie i niskie (4) oraz nałożone na niego efekty (5) (TODO).
Wykres (6) pokazuje aktualne natężenie sygnału mikrofonu.  
 ![obraz](https://github.com/user-attachments/assets/43f4c791-83bf-4329-9057-13c2d91b74ff)

       

Backlog:
- poprawienie generowanie waveform dla plików .wave
- poprawne/dokładne rozmieszczenie GUI
