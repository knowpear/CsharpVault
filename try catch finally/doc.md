﻿- Rules
	- 其中catch块可以有0或者多个，finally可以有0或者1个
	- catch块和finally块可以同时存在且必須存在至少其一
- try块
	- 要捕捉哪些異常
	- 包含了可能出现异常的代码(一条或者多条语句)
- catch块
    - 用来捕捉异常
	- 当代码发生异常，那么异常的类型和catch块中的类型一样的时候，就会执行该catch块
	- 如果catch块的参数不写，表示发生任何异常都执行这个catch块
		- 即catch後不加括號表示捕捉任意類型的異常
	- 實測必須在放在所有catch語句最後
- finally块
	- 包含了始终会执⾏的代码，不管有没有异常产生都会执行
	- 連接數據庫時寫一些資源關閉的代碼