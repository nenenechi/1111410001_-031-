一開始我先打出印出輸入單字和宣告一個陣列，然後做for迴圈來輸入
，但是因為單字數量不確定，我以我改成先輸入單字數量來決定輸入次數
，再來是次數限制，因為只用if來做的話不能重複問，所以我上網找其他方法
，最後用do whilex來檢查，之後的輸入小寫字母，也是用do while來做
，再來是找出含有字元的單字我先創了一個副程式，再用for迴圈來數含有的字元
，有找到字元的回傳值，沒有的回傳null，最後再主程式呼叫，在印出值，但是
執行結果無法正常印出來，所以我又去上網查，知道了要先初始化結果陣列再用
Array.Copy來將找到的值複製到結果陣列和Join 的用法。
