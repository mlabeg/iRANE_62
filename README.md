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

  Przed zainicjowaniem Cue pointów:  
![CUES bez kolorów](https://github.com/user-attachments/assets/de00e327-e516-4896-869e-862752895206)  
  
  Po zainicjowaniu:
  ![CUES z kolorami](https://github.com/user-attachments/assets/2fd57d6e-f981-442a-997b-70760e0ea8f5)
  ![Waveform z cuepointami](https://github.com/user-attachments/assets/c997fec3-2cf1-4e77-9aba-c878824fcd4c)

  
3. **Sekcja EQ** - sekcja składa się z:  
   (1). **Panorama** - pozwala ustawić balans dźwięku między lewym i prawym kanałem wyjściowym,   
   (2). **High-/LowPassFilter** - pozwala na sterowanie filtrem dolnoprzepustowym (przekręcenie w lewą stronę) oraz górnoprzepustowym (przekręcenie w prawą stronę),  
   (3). **CheckBox** włączający i wyłączający efekty na danym kanale,  
   (4). **Wskaźnik natężenia dźwięku** na danym kanale,  
   (5). **Gain** - steruje poziomem natężenia dźwięku kanału,  
   (6). **Equalizer** - 3 potencjometry pozwalające na sterowanie tonami wysokimi, średnimi i niskimi (patrząc od góry)
     
![new Eq z numerami](https://github.com/user-attachments/assets/ccb8c6bd-2fb4-4aac-b741-55dfd09c7b7c)


4. **Sekcja EFFECTS** - sekcja składa się z:  
   (1). **6 CheckBoxów** wyboru efektu, które decydują jaki efekt w danym momencie powinien być aktywny. Tylko 1 efekt może być aktywny na raz, więc w przypadku wyboru innego efektu poprzedni jest automatycznie wyłączany.  
   (2). **TAP** (BPMCounter) do sprawdzania tempa utworu – naciskanie przycisku zgodnie z rytmem utworu pozwoli określić ilość uderzeń na minutę (BPM) sprawdzanego utworu. W przyszłości czas odbicia efektu echo będzie zależeć od wybitego BPM.  
   (3). **Panel wyświetlający** informacje o aktualnie włączonym efekcie oraz wybijanym rytmie BPM.  
   (4). **ON** włączający lub wyłączający sekcję efektów, wspólny dla całego miksera.  
   (5). **Gain** ustalające wzmocnienie dla aktualnie wybranego efektu.  
 
![new Effects z liczbami](https://github.com/user-attachments/assets/3743e52c-c99a-4848-86b5-27f074757474)

4. **Sekcja LOOP** - pozwala na zapętlenie danego fragmentu utworu.
  - *In* – ustawienie początku pętli,
  - *Out* – ustawienie końca pętli,
  - *Exit* – wyjście z pętli.
  
![obraz](https://github.com/user-attachments/assets/3fe82e56-a389-481f-b4eb-66dd28b69d2f)  

5. **Sekcja FADER** - 3 suwaki kontrolujące poziom natężenia dźwięku.  
- 2 pionowe odpowiadają za natężenie poszczególnych kanałów,
- jeden poziomy (Crossfader) odpowiada za balans między nimi (nie mylić z panoramą).
Działanie crossfadera dobrze obrazuje poniższy wykres, gdzie kolorowe kreski to natężenie dźwięku na poszczególnych kanałach. Przesunięcie suwaka na jedną ze stron spowoduje wyciszenie kanału po przeciwnej stronie.

![dokładny wykres crossfader for GH](https://github.com/user-attachments/assets/630da2aa-4fc7-4a01-aa22-cca0e5ed840b)

![obraz](https://github.com/user-attachments/assets/dbf21b86-a571-474e-ba72-34dac8d00558)
  
7. **Sekcja Mic** - mikser umożliwia rónież obsługę mikrofonu. Ze względu na brak implementacji wykrywania i wyciszania pętli mikrofon najlepiej działa przy odtwarzniu dźwięku przez słuchawki.  
- Przycisk "ON" (1) włącza mikrofon,
- Przycisk "OV" (2) (od OVER) sprawa, że grające kanały są odtwarzane na poziomie 20% zostawiając więcej miejsca na dźwięk mikrofonu.  
Dodatkowo sygnał mikrofonu może być modyfikowanu przez sterowanie jego natężeniem (3), Equalizer wzmacniający/osłabiajacy tony wysokie i niskie (4) oraz nałożone na niego efekty (5).
Wykres (6) pokazuje aktualne natężenie sygnału mikrofonu.  
  
 ![obraz](https://github.com/user-attachments/assets/511a5f0c-5f92-4e77-9e2f-f9c2ec9b2fe6)
       
  
Backlog:
- poprawienie generowanie waveform dla plików .wave
