﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Flashcardgenerator.Models.Localhost;
using Microsoft.EntityFrameworkCore;

namespace Flashcardgenerator.Pages
{
    public partial class AddCardComponent : ComponentBase, IDisposable
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        [Inject]
        protected GlobalsService Globals { get; set; }

        public void Dispose()
        {
            Globals.PropertyChanged -= OnPropertyChanged;
        }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected LocalhostService Localhost { get; set; }

        [Parameter]
        public dynamic briefId { get; set; }

        IEnumerable<Flashcardgenerator.Models.Localhost.Brief> _getBriefsForbriefIdResult;
        protected IEnumerable<Flashcardgenerator.Models.Localhost.Brief> getBriefsForbriefIdResult
        {
            get
            {
                return _getBriefsForbriefIdResult;
            }
            set
            {
                if (!object.Equals(_getBriefsForbriefIdResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getBriefsForbriefIdResult", NewValue = value, OldValue = _getBriefsForbriefIdResult };
                    _getBriefsForbriefIdResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Flashcardgenerator.Models.Localhost.Category> _getCategoriesForcategoryIdResult;
        protected IEnumerable<Flashcardgenerator.Models.Localhost.Category> getCategoriesForcategoryIdResult
        {
            get
            {
                return _getCategoriesForcategoryIdResult;
            }
            set
            {
                if (!object.Equals(_getCategoriesForcategoryIdResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCategoriesForcategoryIdResult", NewValue = value, OldValue = _getCategoriesForcategoryIdResult };
                    _getCategoriesForcategoryIdResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Flashcardgenerator.Models.Localhost.Sentence> _getSentencesForsentenceIdResult;
        protected IEnumerable<Flashcardgenerator.Models.Localhost.Sentence> getSentencesForsentenceIdResult
        {
            get
            {
                return _getSentencesForsentenceIdResult;
            }
            set
            {
                if (!object.Equals(_getSentencesForsentenceIdResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getSentencesForsentenceIdResult", NewValue = value, OldValue = _getSentencesForsentenceIdResult };
                    _getSentencesForsentenceIdResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        Flashcardgenerator.Models.Localhost.Card _card;
        protected Flashcardgenerator.Models.Localhost.Card card
        {
            get
            {
                return _card;
            }
            set
            {
                if (!object.Equals(_card, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "card", NewValue = value, OldValue = _card };
                    _card = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            Globals.PropertyChanged += OnPropertyChanged;
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            var localhostGetBriefsResult = await Localhost.GetBriefs();
            getBriefsForbriefIdResult = localhostGetBriefsResult;

            var localhostGetCategoriesResult = await Localhost.GetCategories();
            getCategoriesForcategoryIdResult = localhostGetCategoriesResult;

            var localhostGetSentencesResult = await Localhost.GetSentences();
            getSentencesForsentenceIdResult = localhostGetSentencesResult;

            card = new Flashcardgenerator.Models.Localhost.Card(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Flashcardgenerator.Models.Localhost.Card args)
        {
            try
            {
                var localhostCreateCardResult = await Localhost.CreateCard(card);
                DialogService.Close(card);
            }
            catch (System.Exception localhostCreateCardException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new Card!" });
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
