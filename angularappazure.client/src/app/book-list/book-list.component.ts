import { Component } from '@angular/core';
import { AppComponent } from '../app.component';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-book-list',
  standalone: true,
  imports: [AppComponent, RouterOutlet],
  templateUrl: './book-list.component.html',
  styleUrl: './book-list.component.css'
})
export class BookListComponent {
  bookTitle: string = "Josh's Books";
}
