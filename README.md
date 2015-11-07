# FChan
C# wrapper for [4chan API](https://github.com/4chan/4chan-API).

Retquest board info:
```C#
  Chan.GetBoard();
```

Request thread page:
```C#
  Chan.GetThreadPage("a", 1);
```

Request thread:
```C#
  Chan.GetThread("a", 9001);
```

This wrapper also helps with those urls:
```C#
  Chan.GetThreadPageUrl("a", 1);
  
  Chan.GetThreadUrl("a", 9001);
  
  Chan.GetThumbnail("a", 1344402680740);
  
  Chan.GetImageUrl("a", 1, ".jpeg");
  
  Chan.GetCountryFlagUrl("br");
```


The creators of this software share no affiliation with 4chan in any form.
