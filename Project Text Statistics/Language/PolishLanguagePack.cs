/***************************************************************************\
Author:       Grzegorz Cisek
Mail:         grzegorz.cisek@mail.com
Project:      Project Text Statistics
File:         PolishLanguagePack.cs
Copyright (c) XYZ Corporation.

This source is subject to the Microsoft Public License.
See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
All other rights reserved.

THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/

namespace ProjectTextStatistics.Language {
    /// <summary>
    /// Contains all strings used by application which are visible to users.
    /// </summary>
    /// <remarks>
    /// Language: Polish
    /// </remarks>
    class PolishLanguagePack : PresenterLanguagePack, GuiLanguagePack {

        // from PresenterLanguagePack
        public string SummaryHeader {
            get { return "Łączne statystyki projektu:"; }
        }
        public string FileAnalyzePrefix {
            get { return ""; }
        }
        public string FileCountLabel {
            get { return "Ilość plików: "; }
        }
        public string WordLengthLabel { 
            get { return "Ilość słów: "; } 
        }
        public string CharacterLengthLabel {
            get { return "Ilość znaków: "; }
        }
        public string LineLengthLabel {
            get { return "Ilość lini: "; }
        }
        public string CanNotAccessFile {
            get { return "Nie można uzyskać dostępu do pliku"; }
        }
        public string AccessDeniedException {
            get { return "Brak praw dostępu."; }
        }
        public string DirectoryNotFoundException {
            get { return "Wprowadzony katalog nie istnieje."; }
        }
        public string NotADirectoryException {
            get { return "Wprowadzony obiekt nie jest katalogiem."; }
        }
        public string UnexpectedException {
            get { return "Wystąpił nieoczekiwany błąd."; }
        }
        public string EmptyDirectoryException {
            get { return "Nie odnaleziono plików w katalogu."; }
        }
        public string RegexFormatException {
            get { return "Błąd składni wyrażenia regularnego."; }
        }

        // from GuiLanguagePack
        public string ErrorBoxName {
            get { return "Katastrofa"; } 
        }
        public string NoDirectoryError {
            get { return "Proszę wprowadzić folder projektu."; }
        }
        public string NoRuleError {
            get { return "Proszę wprowadzić regułę lub wyłączyć funkcję filtru."; } 
        }
        public string EnterDirectoryLabel {
            get { return "Foler projektu:"; }
        }
        public string AnalysisScopeGroupLabel {
            get { return "Zakres analizy plików"; }
        }
        public string TopLevelScopeLabel {
            get { return "tylko w wybranym folderze"; }
        }
        public string AllLevelsScopeLabel {
            get { return "folder i podfoldery"; }
        }
        public string NameFilterLabel {
            get { return "Filtruj po nazwie pliku"; }
        }
        public string RegexFilterLabel {
            get { return "Traktuj jako wyrażenie regularne"; }
        }
        public string StartButtonLabel {
            get { return "Start"; }
        }
        public string WindowApplicationLabel {
            get { return "Licznik Statystyki Tekstu"; }
        }
    }
}
