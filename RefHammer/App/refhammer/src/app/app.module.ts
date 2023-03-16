import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FactionService } from './Services/factions.service';
import { StratagemsComponent } from './Stratagems/stratagems/stratagems.component';

@NgModule({
  declarations: [
    AppComponent,
    StratagemsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule 
  ],
  providers: [
    FactionService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
