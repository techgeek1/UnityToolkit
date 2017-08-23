using System;
using System.Linq;
using UnityEngine;
using UnityEditor;

namespace UnityToolkit.Editor.Controls {
    public class SearchBox : Control {
        private string _query = "";
        private List<string> _searchIndex = null;
        
        // Autocomplete
        private bool _enableAutocomplete = false;
        private int _autocompleteMinCharacters = 2;
        private int _autocompleteMaxSuggestions = 20;
        private bool _autocompleteCanScroll = true;
        
        public override void Draw() {
            
        }
        
        public override void DrawAbsolute(Rect position) {
            
        }
        
        private void Autocomplete() {
            
        }
        
        public string Query {
            get {
                return _query;
            }
            set {
                _query = value;
            }
        }
        
        public int AutocompleteMinCharacters {
            get {
                return _autocompleteMinCharacters;
            }
            set {
                _autocompleteMinCharacters = value;
            }
        }
        
        public List<string> SearchIndex {
            get {
                return _searchIndex;
            }
            set {
                _searchIndex = value;
            }
        }
    }
}