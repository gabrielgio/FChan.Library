# FChan
C# wrapper for [4chan API](https://github.com/4chan/4chan-API).

Request boards' info:
```C#
  Chan.GetBoard();
```

Request thread's page:
```C#
  Chan.GetThreadPage("a", 1);
```

Request thread:
```C#
  Chan.GetThread("a", 9001);
```

This wrapper also helps with those urls:
```C#
  Constants.GetThreadPageUrl("a", 1);
  
  Constants.GetThreadUrl("a", 9001);
  
  Constants.GetThumbnail("a", 1344402680740);
  
  Constants.GetImageUrl("a", 1, ".jpeg");
  
  Constants.GetCountryFlagUrl("br");
```


The creators of this software share no affiliation with 4chan in any form.
