import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { GameComponent } from './game/game.component';
import { StratagemsComponent } from './Stratagems/stratagems/stratagems.component';

const routes: Routes = [
  {
      path: '',
    component: AppComponent
  },
  {
    path: 'stratagems',
    component: StratagemsComponent
  },
  {
    path: 'game',
    component: GameComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
