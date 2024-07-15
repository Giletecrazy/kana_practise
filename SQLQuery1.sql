Create Database bdJPWRITINGSYSTEM

use bdJPWRITINGSYSTEM
go

Create Table Kanji(
	id int identity(1,1) primary key,
	Hiragana ntext,
	Romanji ntext
);

Create Table HiraganaMain(
	id int identity(1,1) primary key,
	Hiragana ntext,
	Romanji ntext
);

use bdJPWRITINGSYSTEM
go

Create Table HiraganaDakuten(
	id int identity(1,1) primary key,
	Hiragana ntext,
	Romanji ntext
);

Create Table HiraganaCombination(
	id int identity(1,1) primary key,
	Hiragana ntext,
	Romanji ntext
);

Create Table KatakanaMain(
	id int identity(1,1) primary key,
	Hiragana ntext,
	Romanji ntext
);

Create Table KatakanaDakuten(
	id int identity(1,1) primary key,
	Hiragana ntext,
	Romanji ntext
);

use bdJPWRITINGSYSTEM
go

Create Table KatakanaaCombination(
	id int identity(1,1) primary key,
	Hiragana ntext,
	Romanji ntext
);


use bdJPWRITINGSYSTEM
go

insert into HiraganaMain (Hiragana, Romanji) values
(N'あ','a'),
(N'え','e'),
(N'い','i'),
(N'お','o'),
(N'う','u'),
(N'か','ka'),
(N'け','ke'),
(N'き','ki'),
(N'こ','ko'),
(N'く','ku'),
(N'さ','sa'),
(N'せ','se'),
(N'し','shi'),
(N'そ','so'),
(N'す','su'),
(N'た','ta'),
(N'て','te'),
(N'ち','chi'),
(N'と','to'),
(N'つ','tsu'),
(N'な','na'),
(N'ね','ne'),
(N'に','ni'),
(N'の','no'),
(N'ぬ','nu'),
(N'は','ha'),
(N'へ','he'),
(N'ひ','hi'),
(N'ほ','ho'),
(N'ふ','fu'),
(N'ま','ma'),
(N'め','me'),
(N'み','mi'),
(N'も','mo'),
(N'む','mu'),
(N'や','ya'),
(N'よ','yo'),
(N'ゆ','yu'),
(N'ら','ra'),
(N'れ','re'),
(N'り','ri'),
(N'ろ','ro'),
(N'る','ru'),
(N'わ','wa'),
(N'を','wo'),
(N'ん','n');

use bdJPWRITINGSYSTEM
go

insert into HiraganaDakuten (Hiragana, Romanji) values
(N'が','ga'),
(N'げ','ge'),
(N'ぎ','gi'),
(N'ご','go'),
(N'ぐ','gu'),
(N'ざ','za'),
(N'ぜ','ze'),
(N'じ','ji'),
(N'ぞ','zo'),
(N'ず','zu'),
(N'だ','da'),
(N'で','de'),
(N'ぢ','ji'),
(N'ど','do'),
(N'づ','zu'),
(N'ば','ba'),
(N'べ','be'),
(N'び','bi'),
(N'ぼ','bo'),
(N'ぶ','bu'),
(N'ぱ','pa'),
(N'ぺ','pe'),
(N'ぴ','pi'),
(N'ぽ','po'),
(N'ぷ','pu');

insert into HiraganaCombination (Hiragana, Romanji) values
(N'きや','kya'),
(N'きよ','kyo'),
(N'きゆ','kyu'),
(N'ぎや','gya'),
(N'ぎよ','gyo'),
(N'ぎゆ','gyu'),
(N'しや','sha'),
(N'しよ','sho'),
(N'しゆ','shu'),
(N'じや','ja'),
(N'じよ','jo'),
(N'じゆ','ju'),
(N'ちや','cha'),
(N'ちよ','cho'),
(N'ちゆ','chu'),
(N'ぢや','ja'),
(N'ぢよ','jo'),
(N'ぢゆ','ju'),
(N'にや','nya'),
(N'によ','nyo'),
(N'にゆ','nyu'),
(N'ひや','hya'),
(N'ひよ','hyo'),
(N'ひゆ','hyu'),
(N'びや','bya'),
(N'びよ','byo'),
(N'びゆ','byu'),
(N'ぴや','pya'),
(N'ぴよ','pyo'),
(N'ぴゆ','pyu'),
(N'みや','mya'),
(N'みよ','myo'),
(N'みゆ','myu'),
(N'りや','rya'),
(N'りよ','ryo'),
(N'りゆ','ryu');

insert into KatakanaMain (Hiragana, Romanji) values
(N'ァ','a'),
(N'エ','e'),
(N'イ','i'),
(N'オ','o'),
(N'ウ','u'),
(N'カ','ka'),
(N'ケ','ke'),
(N'キ','ki'),
(N'コ','ko'),
(N'ク','ku'),
(N'サ','sa'),
(N'セ','se'),
(N'シ','shi'),
(N'ソ','so'),
(N'ス','su'),
(N'タ','ta'),
(N'テ','te'),
(N'チ','chi'),
(N'ト','to'),
(N'ッ','tsu'),
(N'ナ','na'),
(N'ネ','ne'),
(N'二','ni'),
(N'ノ','no'),
(N'ヌ','nu'),
(N'ハ','ha'),
(N'ヘ','he'),
(N'ヒ','hi'),
(N'ホ','ho'),
(N'フ','fu'),
(N'マ','ma'),
(N'メ','me'),
(N'ミ','mi'),
(N'モ','mo'),
(N'厶','mu'),
(N'ヤ','ya'),
(N'ヨ','yo'),
(N'ユ','yu'),
(N'ラ','ra'),
(N'レ','re'),
(N'リ','ri'),
(N'ロ','ro'),
(N'ル','ru'),
(N'ワ','wa'),
(N'ヲ','wo'),
(N'ン','n');

insert into KatakanaDakuten (Hiragana, Romanji) values
(N'ガ','ga'),
(N'ゲ','ge'),
(N'ギ','gi'),
(N'ゴ','go'),
(N'グ','gu'),
(N'ザ','za'),
(N'ゼ','ze'),
(N'ジ','ji'),
(N'ゾ','zo'),
(N'ズ','zu'),
(N'ダ','da'),
(N'デ','de'),
(N'ヂ','ji'),
(N'ド','do'),
(N'ヅ','zu'),
(N'バ','ba'),
(N'ベ','be'),
(N'ビ','bi'),
(N'ボ','bo'),
(N'ブ','bu'),
(N'パ','pa'),
(N'ペ','pe'),
(N'ピ','pi'),
(N'ポ','po'),
(N'プ','pu');

use bdJPWRITINGSYSTEM
go

insert into KatakanaaCombination (Hiragana, Romanji) values
(N'キヤ','kya'),
(N'キヨ','kyo'),
(N'キユ','kyu'),
(N'ギヤ','gya'),
(N'ギヨ','gyo'),
(N'ギユ','gyu'),
(N'シヤ','sha'),
(N'シヨ','sho'),
(N'シユ','shu'),
(N'ジャ','ja'),
(N'ジヨ','jo'),
(N'ジユ','ju'),
(N'チヤ','cha'),
(N'チヨ','cho'),
(N'チユ','chu'),
(N'ヂヤ','ja'),
(N'ヂヨ','jo'),
(N'ヂユ','ju'),
(N'ニヤ','nya'),
(N'ニヨ','nyo'),
(N'ニユ','nyu'),
(N'ヒヤ','hya'),
(N'ヒヨ','hyo'),
(N'ヒユ','hyu'),
(N'ビヤ','bya'),
(N'ビヨ','byo'),
(N'ビユ','byu'),
(N'ピヤ','pya'),
(N'ピヨ','pyo'),
(N'ピユ','pyu'),
(N'ミヤ','mya'),
(N'ミヨ','myo'),
(N'ミユ','myu'),
(N'リヤ','rya'),
(N'リヨ','ryo'),
(N'リユ','ryu');